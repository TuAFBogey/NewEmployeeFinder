using AutoMapper;
using Microsoft.AspNetCore.Authorization;
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
    //[Authorize]
    //[ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        private readonly IMapper _mapper;
        public DepartmentsController(IDepartmentService departmentService, IMapper mapper)
        {
            _departmentService = departmentService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var departments = await _departmentService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<DepartmentDto>>(departments));
        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var department = await _departmentService.GetByIdAsync(id);
            return Ok(_mapper.Map<DepartmentDto>(department));
        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpGet("{id}/employees")]
        public async Task<IActionResult> GetWithEmployeesById(int id)
        {
            var department = await _departmentService.GetWithEmployeesByIdAsync(id);
            return Ok(_mapper.Map<DepartmentWithEmployeeDto>(department));
        }

        [ValidationFilter]
        [HttpPost]
        public async Task<IActionResult> Save(DepartmentDto departmentDto)
        {
            var newDepartment = await _departmentService.AddAsync(_mapper.Map<Department>(departmentDto));
            return Created(string.Empty, _mapper.Map<DepartmentDto>(newDepartment));
        }

        [HttpPut]
        public IActionResult Update(DepartmentDto departmentDto)
        {
            var department = _departmentService.Update(_mapper.Map<Department>(departmentDto));
            return NoContent();
        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var department = await _departmentService.GetByIdAsync(id);
            _departmentService.Remove(department);
            return NoContent();
        }
    }
}
