using System;
using System.Collections.Generic;

namespace SoftServe_IT_Academy.Project.Models
{
    public class News
    {
        public News()
        {
            Teams = new HashSet<NewsTeam>();
            Authors = new HashSet<NewsAuthor>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime PostedOn { get; set; }

        public int StateId { get; set; }
        public virtual State State { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<NewsTeam> Teams { get; set; }
        public virtual ICollection<NewsAuthor> Authors { get; set; }
    }
}
