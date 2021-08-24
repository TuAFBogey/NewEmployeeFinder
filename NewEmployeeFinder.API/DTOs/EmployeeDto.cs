using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewEmployeeFinder.API.DTOs
{
    public class EmployeeDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Employee Name is Required")]
        public string Name { get; set; }

        public int DepartmentId { get; set; }

        public int ProjectId { get; set; }
        
        public int CityId { get; set; }
    }
}
