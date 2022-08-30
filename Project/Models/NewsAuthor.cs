namespace SoftServe_IT_Academy.Project.Models
{
    public class NewsAuthor
    {
        public int NewsId { get; set; }
        public virtual News News { get; set; }

        public int AuthorId { get; set; }
        public virtual User Author { get; set; }
    }
}
