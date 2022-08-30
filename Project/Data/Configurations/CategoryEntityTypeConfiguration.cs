﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftServe_IT_Academy.Project.Models;

namespace SoftServe_IT_Academy.Project.Data.Configurations
{
    internal class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> category)
        {
            category.Property(x => x.Name)
                .IsRequired(true)
                .HasMaxLength(50)
                .IsUnicode(false);

            category.Property(x => x.Description)
                .IsRequired(false)
                .HasMaxLength(250)
                .IsUnicode(false);
        }
    }
}
