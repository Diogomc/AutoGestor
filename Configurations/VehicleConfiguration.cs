using AutoGestor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoGestor.Configurations;

public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
{
    public void Configure(EntityTypeBuilder<Vehicle> builder)
    {
        builder.HasKey(v => v.VehicleId);
        builder.Property(v => v.Model).IsRequired();
        builder.Property(e => e.Brand).IsRequired();
        builder.Property(e => e.Color).IsRequired();
        builder.Property(e => e.ProductionYear).IsRequired();
        builder.Property(v => v.Plate).IsRequired();
    }
}
