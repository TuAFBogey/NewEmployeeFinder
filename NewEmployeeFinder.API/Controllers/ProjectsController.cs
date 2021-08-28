﻿using AutoMapper;
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
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;
        private readonly IMapper _mapper;
        public ProjectsController(IProjectService projectService, IMapper mapper)
        {
            _projectService = projectService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var projects = await _projectService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<ProjectDto>>(projects));
        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var project = await _projectService.GetByIdAsync(id);
            return Ok(_mapper.Map<ProjectDto>(project));
        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpGet("{id}/employees")]
        public async Task<IActionResult> GetWithEmployeesById(int id)
        {
            var project = await _projectService.GetWithEmployeesByIdAsync(id);
            return Ok(_mapper.Map<ProjectWithEmployeeDto>(project));
        }

        [ValidationFilter]
        [HttpPost]
        public async Task<IActionResult> Save(ProjectDto projectDto)
        {
            var newProject = await _projectService.AddAsync(_mapper.Map<Project>(projectDto));
            return Created(string.Empty, _mapper.Map<ProjectDto>(newProject));
        }

        [HttpPut]
        public IActionResult Update(ProjectDto projectDto)
        {
            var project = _projectService.Update(_mapper.Map<Project>(projectDto));
            return NoContent();
        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var project = await _projectService.GetByIdAsync(id);
            _projectService.Remove(project);
            return NoContent();
        }
    }
}
