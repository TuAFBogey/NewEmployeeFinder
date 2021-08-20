using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewEmployeeFinder.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewEmployeeFinder.Data.Seeds
{
    public class DepartmentSeed : IEntityTypeConfiguration<Department>
    {
        private readonly int[] _ids;
        public DepartmentSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasData(
                new Department { Id = _ids[0], Name = "Software"},
                new Department { Id = _ids[1], Name = "Embedded Software"},
                new Department { Id = _ids[2], Name = "R&D"},
                new Department { Id = _ids[3], Name = "Human Resources"});
        }
    }
}
