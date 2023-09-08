using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task = Domain.Entities.Task;

namespace Infrastructure.EntitiesConfigurations;

public class BoardConfiguration : IEntityTypeConfiguration<Task>
{
    public void Configure(EntityTypeBuilder<Task> builder)
    {
        builder.HasIndex(e => e.Id);

        builder.Property(e => e.Name)
            .HasMaxLength(125)
            .IsRequired();
    }
}