using Entidades.Configuration.Gerencia;
using Microsoft.EntityFrameworkCore;

namespace Persistencia.Contexts.Gerencia
{
    public partial class GerenciaContext : DbContext
    {
        public GerenciaContext()
        {
        }

        public GerenciaContext(DbContextOptions<GerenciaContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=lgsm;Database=gerencia;User Id=sa;Password=senha",
                b => b.MigrationsAssembly("Migrations")).EnableDetailedErrors();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "1.0.0");

            modelBuilder.ApplyConfiguration(new ClienteConfig());
            modelBuilder.ApplyConfiguration(new EmpresaConfig());
            modelBuilder.ApplyConfiguration(new UsuarioConfig());
        }
    }
}
