using Microsoft.EntityFrameworkCore;
using NewEmployeeFinder.Entities.Entities;
using NewEmployeeFinder.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeFinder.Data.Repositories
{
    class CityRepository : Repository<City>, ICityRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public CityRepository(DbContext context) : base(context)
        {
        }

        public async Task<City> GetWithEmployeesByIdAsync(int cityId)
        {
            return await _appDbContext.Cities.Include(x => x.Employees).SingleOrDefaultAsync(x => x.Id == cityId);
        }
    }
}
