﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftServe_IT_Academy.Project.Models;

namespace SoftServe_IT_Academy.Project.Data.Configurations
{
    internal class TeamEntityTypeConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> team)
        {
            team.Property(x => x.Name)
                .IsRequired(true)
                .HasMaxLength(50)
                .IsUnicode(false);

            team.Property(x => x.Description)
                .IsRequired(false)
                .HasMaxLength(250)
                .IsUnicode(false);
        }
    }
}
