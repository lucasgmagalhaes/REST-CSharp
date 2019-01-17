using Entidades.Models;
using Persistencia.Contexts.Gerencia;
using Persistencia.Interfaces;

namespace Persistencia.Services
{
    public class AutenticacaoService : CrudService<Usuario>, IAutenticacaoService
    {
        public AutenticacaoService(GerenciaContext context) : base(context) { }
    }
}
