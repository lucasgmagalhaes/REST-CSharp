using Entidades.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistencia.Contexts
{
    public class UsuarioContext: DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
