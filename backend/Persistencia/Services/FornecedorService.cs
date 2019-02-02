using Entidades.Entidades.App;
using Persistencia.Contexts.Application;
using Persistencia.Interfaces;

namespace Persistencia.Services
{
    public class FornecedorService : CrudService<Fornecedor>, IFornecedorService
    {
        public FornecedorService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
