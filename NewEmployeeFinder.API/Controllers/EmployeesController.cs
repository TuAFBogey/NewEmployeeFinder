using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewEmployeeFinder.API.DTOs;
using NewEmployeeFinder.API.Filters;
using NewEmployeeFinder.Core.Services;
using NewEmployeeFinder.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEmployeeFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;
        public EmployeesController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var employees = await _employeeService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<EmployeeDto>>(employees));
        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var employee = await _employeeService.GetByIdAsync(id);
            return Ok(_mapper.Map<EmployeeDto>(employee));
        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpGet("{id}/department")]
        public async Task<IActionResult> GetWithDepartmentsById(int id)
        {
            var employee = await _employeeService.GetWithDepartmentByIdAsync(id);
            return Ok(_mapper.Map<EmployeeWithDepartmentDto>(employee));
        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpGet("{id}/project")]
        public async Task<IActionResult> GetWithProjectsById(int id)
        {
            var employee = await _employeeService.GetWithProjectByIdAsync(id);
            return Ok(_mapper.Map<EmployeeWithProjectDto>(employee));
        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpGet("{id}/city")]
        public async Task<IActionResult> GetWithCitiesById(int id)
        {
            var employee = await _employeeService.GetWithCityByIdAsync(id);
            return Ok(_mapper.Map<EmployeeWithCityDto>(employee));
        }

        [ValidationFilter]
        [HttpPost]
        public async Task<IActionResult> Save(EmployeeDto employeeDto)
        {
            var newEmployee = await _employeeService.AddAsync(_mapper.Map<Employee>(employeeDto));
            return Created(string.Empty, _mapper.Map<EmployeeDto>(newEmployee));
        }

        [HttpPut]
        public IActionResult Update(EmployeeDto employeeDto)
        {
            var employee = _employeeService.Update(_mapper.Map<Employee>(employeeDto));
            return NoContent();
        }
        
        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var employee = await _employeeService.GetByIdAsync(id);
            _employeeService.Remove(employee);
            return NoContent();
        }
    }
}
