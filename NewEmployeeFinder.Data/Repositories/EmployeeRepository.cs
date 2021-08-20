﻿using Microsoft.EntityFrameworkCore;
using NewEmployeeFinder.Entities.Entities;
using NewEmployeeFinder.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeFinder.Data.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {

        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public EmployeeRepository(DbContext context) : base(context)
        {
        }

        public async Task<Employee> GetWithCityByIdAsync(int employeeId)
        {
            return await _appDbContext.Employees.Include(x => x.City).SingleOrDefaultAsync(x => x.Id == employeeId);
        }

        public async Task<Employee> GetWithDepartmentByIdAsync(int employeeId)
        {
            return await _appDbContext.Employees.Include(x => x.Department).SingleOrDefaultAsync(x => x.Id == employeeId);
        }

        public async Task<Employee> GetWithProjectByIdAsync(int employeeId)
        {
            return await _appDbContext.Employees.Include(x => x.Project).SingleOrDefaultAsync(x => x.Id == employeeId);
        }
    }
}
