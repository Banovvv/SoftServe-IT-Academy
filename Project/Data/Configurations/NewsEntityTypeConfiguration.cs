using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftServe_IT_Academy.Project.Models;

namespace SoftServe_IT_Academy.Project.Data.Configurations
{
    internal class NewsEntityTypeConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> news)
        {
            news.Property(x => x.Title)
                .IsRequired(true)
                .HasMaxLength(100)
                .IsUnicode(false);

            news.Property(x => x.Content)
                .IsRequired(true)
                .IsUnicode(false);

            news.Property(x => x.CreatedOn)
                .IsRequired(true)
                .HasDefaultValueSql("GETDATE()");

            news.Property(x => x.PostedOn)
                .IsRequired(false);
        }
    }
}
