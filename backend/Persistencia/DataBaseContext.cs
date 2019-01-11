using Microsoft.EntityFrameworkCore;
using Persistencia.EntityConfiguration;

namespace Persistencia
{
    public partial class DataBaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LGSM;Database=dbApi;User ID=sa;Password=senha;")
                    .EnableDetailedErrors();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "1.0.0");

            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioImagemConfiguration());
        }
    }
}