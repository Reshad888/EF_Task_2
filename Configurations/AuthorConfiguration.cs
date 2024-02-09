using EF_Task_2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Task_2.Configurations;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
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