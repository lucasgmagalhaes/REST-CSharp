using Entidades.Entidades.App;
using Microsoft.EntityFrameworkCore;

namespace Persistencia.Contexts.Application
{
    public partial class ApplicationDbContext
    {
        public virtual DbSet<Fornecedor> Fornecedor { get; set; }
    }
}
