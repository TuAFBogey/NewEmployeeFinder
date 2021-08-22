using NewEmployeeFinder.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewEmployeeFinder.Core.Services
{
    public interface IEmployeeService : IService<Employee>
    {
        Task<Employee> GetWithDepartmentByIdAsync(int employeeId);

        Task<Employee> GetWithProjectByIdAsync(int employeeId);

        Task<Employee> GetWithCityByIdAsync(int employeeId);
    }
}
