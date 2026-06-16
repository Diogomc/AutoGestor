using AutoGestor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoGestor.Configurations;

public class WorkOrderConfiguration : IEntityTypeConfiguration<WorkOrder>
{
    public void Configure(EntityTypeBuilder<WorkOrder> builder)
    {
        builder.HasKey(w => w.WorkOrderId);
        builder.Property(w => w.Complaint).IsRequired();
        builder.Property(w => w.RequestedServices).IsRequired();
        builder.Property(w => w.Diagnostic).IsRequired();
    }
}
