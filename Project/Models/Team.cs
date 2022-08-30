using System.Collections.Generic;

namespace SoftServe_IT_Academy.Project.Models
{
    public class Team
    {
        public Team()
        {
            News = new HashSet<NewsTeam>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int LeagueId { get; set; }
        public virtual League League { get; set; }

        public virtual ICollection<NewsTeam> News { get; set; }
    }
}
