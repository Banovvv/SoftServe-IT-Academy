using System.Collections.Generic;

namespace SoftServe_IT_Academy.Project.Models
{
    public class State
    {
        public State()
        {
            News = new HashSet<News>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<News> News { get; set; }
    }
}
