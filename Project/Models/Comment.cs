using System;

namespace SoftServe_IT_Academy.Project.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime PostedOn { get; set; }

        public int NewsId { get; set; }
        public virtual News News { get; set; }

        public int AuthorId { get; set; }
        public virtual User Author { get; set; }
    }
}
