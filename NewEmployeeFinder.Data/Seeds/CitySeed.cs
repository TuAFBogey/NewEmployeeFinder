using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewEmployeeFinder.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewEmployeeFinder.Data.Seeds
{
    public class CitySeed : IEntityTypeConfiguration<City>
    {
        private readonly int[] _ids;
        public CitySeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(
                new City { Id = _ids[0], Name = "Eskişehir" },
                new City { Id = _ids[1], Name = "Ankara" },
                new City { Id = _ids[2], Name = "İstanbul" }
                );
        }
    }
}
