using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftServe_IT_Academy.Project.Models;

namespace SoftServe_IT_Academy.Project.Data.Configurations
{
    internal class NewsTeamEntityTypeConfiguration : IEntityTypeConfiguration<NewsTeam>
    {
        public void Configure(EntityTypeBuilder<NewsTeam> newsTeam)
        {
            newsTeam
                .HasKey(x => new
                {
                    x.NewsId,
                    x.TeamId
                });
        }
    }
}
