using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftServe_IT_Academy.Project.Models;

namespace SoftServe_IT_Academy.Project.Data.Configurations
{
    internal class CommentEntityTypeConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> comment)
        {
            comment.Property(x => x.Content)
                .IsRequired(true)
                .HasMaxLength(450)
                .IsUnicode(false);

            comment.Property(x => x.PostedOn)
                .IsRequired(true)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}
