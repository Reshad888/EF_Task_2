using EF_Task_2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Task_2.Configurations;

public class LibConfiguration : IEntityTypeConfiguration<Lib>
{
    public void Configure(EntityTypeBuilder<Lib> builder)
    {
        // FirstName
        builder.Property("FirstName")
            .HasColumnType("nvarchar(max)")
            .IsRequired();

        // LastName
        builder.Property("LastName")
            .HasColumnType("nvarchar(max)")
            .IsRequired();
    }
}