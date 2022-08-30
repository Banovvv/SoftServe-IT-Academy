using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftServe_IT_Academy.Project.Models;

namespace SoftServe_IT_Academy.Project.Data.Configurations
{
    internal class NewsAuthorEntityTypeConfiguration : IEntityTypeConfiguration<NewsAuthor>
    {
        public void Configure(EntityTypeBuilder<NewsAuthor> newsAuthor)
        {
            newsAuthor
                .HasKey(x => new
                {
                    x.NewsId,
                    x.AuthorId
                });
        }
    }
}
