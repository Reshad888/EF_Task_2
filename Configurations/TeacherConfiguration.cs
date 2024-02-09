using EF_Task_2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Task_2.Configurations;

public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        // FirstName
        builder.Property("FirstName")
            .HasColumnType("nvarchar(max)")
            .IsRequired();

        // LastName
        builder.Property("LastName")
            .HasColumnType("nvarchar(max)")
            .IsRequired();

        // Id_Dep
        builder.HasOne(t => t.Department)
            .WithMany(d => d.Teachers)
            .HasForeignKey(t => t.Id_Dep);
    }
}