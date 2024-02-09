﻿using EF_Task_2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Task_2.Configurations;

public class ThemeConfiguration : IEntityTypeConfiguration<Theme>
{
    public void Configure(EntityTypeBuilder<Theme> builder)
    {
        // Name
        builder.Property("Name")
            .HasColumnType("nvarchar(max)")
            .IsRequired();
    }
}