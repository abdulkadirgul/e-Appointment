using eAppointmentServer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAppointmentServer.Infrastructure.Configurations
{
    internal sealed class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.Property(p=>p.FirstName).HasColumnType("vharchar(50)");
            builder.Property(p=>p.LastName).HasColumnType("vharchar(50)");
            //builder.HasIndex(p => new { p.FirstName, p.LastName }).IsUnique();
        }

    }
}
