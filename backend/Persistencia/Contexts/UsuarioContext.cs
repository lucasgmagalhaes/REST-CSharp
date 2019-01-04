using Microsoft.EntityFrameworkCore;

namespace Persistencia.Contexts
{
    public class GenericDatabase<T> : DbContext where T : class
    {
        public DbSet<T> context
        {
            get
            {
                return base.Set<T>();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
        }
    }
}
