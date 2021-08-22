using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEmployeeFinder.API.DTOs
{
    public class EmployeeWithCityDto : EmployeeDto
    {
        public CityDto City { get; set; }
    }
}
