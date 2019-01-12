using Microsoft.EntityFrameworkCore.Design;

namespace Persistencia.Configuration
{
    public class ApplicationDesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        /// <summary>
        /// Check the environment variable, and create a new ApplicationDbContext accordingly.
        /// </summary>
        /// <returns></returns>
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            return new ApplicationDbContext();
        }
    }
}
