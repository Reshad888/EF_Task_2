using EF_Task_2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Task_2.Configurations;

public class GroupConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        // Name
        builder.Property("Name")
            .HasColumnType("nvarchar(max)")
            .IsRequired();

        // Id_Faculty
        builder.HasOne(g => g.Faculty)
            .WithMany(f => f.Groups)
            .HasForeignKey(g => g.Id_Faculty)
            .IsRequired();
    }
}