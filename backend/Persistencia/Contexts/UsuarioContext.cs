using Entidades.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistencia.Contexts
{
    public class UserContext: DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
