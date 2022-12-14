using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftServe_IT_Academy.Project.Models;

namespace SoftServe_IT_Academy.Project.Data.Configurations
{
    internal class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> user)
        {
            user.HasIndex(x => x.Username)
                .IsUnique();

            user.Property(x => x.Email)
                .IsRequired(true)
                .HasMaxLength(50)
                .IsUnicode(false);

            user.Property(x => x.Username)
                .IsRequired(true)
                .HasMaxLength(50)
                .IsUnicode(false);

            user.Property(x => x.DisplayName)
                .IsRequired(true)
                .HasMaxLength(50)
                .IsUnicode(false);

            user.Property(x => x.Pseudonym)
                .IsRequired(false)
                .HasMaxLength(50)
                .IsUnicode(false);

            user.Property(x => x.FirstName)
                .IsRequired(true)
                .HasMaxLength(50)
                .IsUnicode(false);

            user.Property(x => x.LastName)
                .IsRequired(true)
                .HasMaxLength(50)
                .IsUnicode(false);

            user.Property(x => x.Password)
                .IsRequired(true)
                .HasMaxLength(60)
                .IsUnicode(false);

            user.Property(x => x.ProfilePicture)
                .IsRequired(false);
        }
    }
}
