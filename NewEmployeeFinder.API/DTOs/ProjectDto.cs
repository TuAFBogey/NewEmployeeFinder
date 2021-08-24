using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewEmployeeFinder.API.DTOs
{
    public class ProjectDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Project Name is Required")]
        public string Name { get; set; }
    }
}
