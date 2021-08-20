using NewEmployeeFinder.Core.Services;
using NewEmployeeFinder.Core.UnitOfWorks;
using NewEmployeeFinder.Entities.Entities;
using NewEmployeeFinder.Entities.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeFinder.Service.Services
{
    public class EmployeeService : Service<Employee>, IEmployeeService
    {
        public EmployeeService(IUnitOfWork unitOfWork, IRepository<Employee> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Employee> GetWithCityByIdAsync(int employeeId)
        {
            return await _unitOfWork.Employees.GetWithCityByIdAsync(employeeId);
        }

        public async Task<Employee> GetWithDepartmentByIdAsync(int employeeId)
        {
            return await _unitOfWork.Employees.GetWithDepartmentByIdAsync(employeeId);
        }

        public async Task<Employee> GetWithProjectByIdAsync(int employeeId)
        {
            return await _unitOfWork.Employees.GetWithProjectByIdAsync(employeeId);
        }
    }
}
