using eAppointmentServer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eAppointmentServer.Infrastructure.Configurations
{
    internal sealed class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {

        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.Property(p => p.FirstName).HasColumnType("vharchar(50)");
            builder.Property(p => p.LastName).HasColumnType("vharchar(50)");
            builder.Property(p => p.City).HasColumnType("vharchar(50)");
            builder.Property(p => p.Town).HasColumnType("vharchar(50)");
            builder.Property(p => p.FullAddress).HasColumnType("vharchar(400)");
            builder.Property(p => p.IdentityNumber).HasColumnType("vharchar(11)");
            builder.HasIndex(p => p.IdentityNumber).IsUnique();
        }
    }
}
