using EF_Task_2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Task_2.Configurations;

public class S_CardConfiguration : IEntityTypeConfiguration<S_Card>
{
    public void Configure(EntityTypeBuilder<S_Card> builder)
    {
        // DateOut
        builder.Property("DateOut")
            .HasColumnType("date")
            .IsRequired();

        // DateIn
        builder.Property("DateIn")
            .HasColumnType("date");

        // Id_Student
        builder.HasOne(sc => sc.Student)
            .WithMany(s => s.S_Cards)
            .HasForeignKey(sc => sc.Id_Student)
            .IsRequired();

        // Id_Book
        builder.HasOne(sc => sc.Book)
            .WithMany(b => b.S_Cards)
            .HasForeignKey(sc => sc.Id_Book)
            .IsRequired();

        // Id_Lib
        builder.HasOne(sc => sc.Lib)
            .WithMany(l => l.S_Cards)
            .HasForeignKey(sc => sc.Id_Lib)
            .IsRequired();
    }
}