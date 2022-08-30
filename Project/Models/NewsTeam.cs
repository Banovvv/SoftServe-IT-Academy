namespace SoftServe_IT_Academy.Project.Models
{
    public class NewsTeam
    {
        public int NewsId { get; set; }
        public virtual News News { get; set; }

        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
    }
}
