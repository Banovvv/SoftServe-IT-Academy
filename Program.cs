using SoftServe_IT_Academy.Project.Data;
using SoftServe_IT_Academy.Project.Data.Seeder;

namespace AccediaTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new ApplicationDbContext();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            Seeder.Seed(context);
        }
    }
}
