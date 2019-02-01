using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Persistencia.Interfaces;

namespace Persistencia.Contexts.Application
{
    public partial class ApplicationDbContext : DbContext, IDbContextSchema
    {
        public string Schema { get; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IDbContextSchema schema = null) : base(options)
        {
            Schema = schema?.Schema;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseSqlServer(ConnectionString.GetConnection(), b => b.MigrationsAssembly("Migrations")).EnableDetailedErrors()
                  .ReplaceService<IModelCacheKeyFactory, DbSchemaAwareModelCacheKeyFactory>();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "1.0.0");

            //modelBuilder.ApplyConfiguration(new UsuarioConfig());
            //modelBuilder.ApplyConfiguration(new UsuarioImagemConfig());
        }
    }
}