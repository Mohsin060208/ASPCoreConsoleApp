using Microsoft.EntityFrameworkCore;

namespace ASPCoreConsoleApp.Entities
{
    public class ActorDbContext: DbContext
    {
        public DbSet<Actor> Actors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ActorDb;Integrated Security=True;");
                
        }
    }
}
