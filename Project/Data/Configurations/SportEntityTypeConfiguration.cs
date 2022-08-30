using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftServe_IT_Academy.Project.Models;

namespace SoftServe_IT_Academy.Project.Data.Configurations
{
    internal class SportEntityTypeConfiguration : IEntityTypeConfiguration<Sport>
    {
        public void Configure(EntityTypeBuilder<Sport> sport)
        {
            sport.Property(x => x.Name)
                .IsRequired(true)
                .HasMaxLength(50)
                .IsUnicode(false);

            sport.Property(x => x.Description)
                .IsRequired(false)
                .HasMaxLength(250)
                .IsUnicode(false);
        }
    }
}
