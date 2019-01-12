using Entidades.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistencia.Contexts.Gerencia
{
    public partial class GerenciaContext : DbContext
    {
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<UsuarioEmpresa> UsuarioEmpresa { get; set; }
    }
}
