using EF_Task_2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Task_2.Configurations;

public class T_CardConfiguration : IEntityTypeConfiguration<T_Card>
{
    public void Configure(EntityTypeBuilder<T_Card> builder)
    {
        // DateOut
        builder.Property("DateOut")
            .HasColumnType("date")
            .IsRequired();

        // DateIn
        builder.Property("DateIn")
            .HasColumnType("date");

        // Id_Teacher
        builder.HasOne(tc => tc.Teacher)
            .WithMany(t => t.T_Cards)
            .HasForeignKey(tc => tc.Id_Teacher)
            .IsRequired();

        // Id_Book
        builder.HasOne(tc => tc.Book)
            .WithMany(b => b.T_Cards)
            .HasForeignKey(tc => tc.Id_Book)
            .IsRequired();

        // Id_Lib
        builder.HasOne(tc => tc.Lib)
            .WithMany(l => l.T_Cards)
            .HasForeignKey(tc => tc.Id_Lib)
            .IsRequired();
    }
}