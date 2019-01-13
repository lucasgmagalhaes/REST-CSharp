using Microsoft.EntityFrameworkCore;

namespace Persistencia.Contexts.Application
{
    public partial class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseSqlServer(ConnectionString.GetConnection(), 
                b => b.MigrationsAssembly("Migrations")).EnableDetailedErrors();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "1.0.0");

            //modelBuilder.ApplyConfiguration(new UsuarioConfig());
            //modelBuilder.ApplyConfiguration(new UsuarioImagemConfig());
        }
    }
}