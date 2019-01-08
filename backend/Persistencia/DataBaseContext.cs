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
                optionsBuilder.UseSqlServer("Server=DESKTOP-9TG6S3I;Database=dbApi;User ID=sa;Password=senha;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioImagemConfiguration());
        }
    }
}