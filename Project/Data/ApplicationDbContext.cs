using Microsoft.EntityFrameworkCore;
using SoftServe_IT_Academy.Project.Data.Configurations;
using SoftServe_IT_Academy.Project.Models;

namespace SoftServe_IT_Academy.Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<League> Leagues { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsAuthor> NewsAuthors { get; set; }
        public virtual DbSet<NewsTeam> NewsTeams { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Sport> Sports { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new CategoryEntityTypeConfiguration().Configure(modelBuilder.Entity<Category>());
            new CommentEntityTypeConfiguration().Configure(modelBuilder.Entity<Comment>());
            new LeagueEntityTypeConfiguration().Configure(modelBuilder.Entity<League>());
            new NewsEntityTypeConfiguration().Configure(modelBuilder.Entity<News>());
            new NewsAuthorEntityTypeConfiguration().Configure(modelBuilder.Entity<NewsAuthor>());
            new NewsTeamEntityTypeConfiguration().Configure(modelBuilder.Entity<NewsTeam>());
            new RoleEntityTypeConfiguration().Configure(modelBuilder.Entity<Role>());
            new SportEntityTypeConfiguration().Configure(modelBuilder.Entity<Sport>());
            new StateEntityTypeConfiguration().Configure(modelBuilder.Entity<State>());
            new TeamEntityTypeConfiguration().Configure(modelBuilder.Entity<Team>());
            new UserEntityTypeConfiguration().Configure(modelBuilder.Entity<User>());
        }
    }
}
