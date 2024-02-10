using EF_Task_2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Task_2.Configurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        // FirstName
        builder.Property("FirstName")
            .HasColumnType("nvarchar(max)")
            .IsRequired();

        // LastName
        builder.Property("LastName")
            .HasColumnType("nvarchar(max)")
            .IsRequired();

        // Term
        builder.Property("Term")
            .HasColumnType("int")
            .IsRequired();

        // Id_Group
        builder.HasOne(s => s.Group)
            .WithMany(g => g.Students)
            .HasForeignKey(s => s.Id_Group)
            .IsRequired();
    }
}