﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEmployeeFinder.API.DTOs
{
    public class DepartmentWithEmployeeDto:DepartmentDto
    {
        public ICollection<EmployeeDto> Employees { get; set; }
    }
}
