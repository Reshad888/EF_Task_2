using EF_Task_2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Task_2.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        // Name
        builder.Property("Name")
            .HasColumnType("nvarchar(max)")
            .IsRequired();

        // Pages
        builder.Property("Pages")
            .HasColumnType("int")
            .IsRequired();

        // YearPress
        builder.Property("YearPress")
            .HasColumnType("int")
            .IsRequired();

        // Comment
        builder.Property("Comment")
            .HasColumnType("nvarchar(max)")
            .IsRequired();

        // Quantity
        builder.Property("Quantity")
            .HasColumnType("int")
            .IsRequired();

        // Id_Theme
        builder.HasOne(b => b.Theme)
            .WithMany(t => t.Books)
            .HasForeignKey(b => b.Id_Theme)
            .IsRequired();

        // Id_Category
        builder.HasOne(b => b.Category)
            .WithMany(c => c.Books)
            .HasForeignKey(b => b.Id_Category)
            .IsRequired();

        // Id_Author
        builder.HasOne(b => b.Author)
            .WithMany(c => c.Books)
            .HasForeignKey(b => b.Id_Author)
            .IsRequired();

        // Id_Press
        builder.HasOne(b => b.Press)
            .WithMany(c => c.Books)
            .HasForeignKey(b => b.Id_Press)
            .IsRequired();
    }
}