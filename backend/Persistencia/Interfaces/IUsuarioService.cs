using Entidades.Entidades.Gerencia;
using System.Collections.Generic;

namespace Persistencia.Interfaces
{
    public interface IUsuarioService : ICrudService<Usuario>
    {
        List<Empresa> BuscarEmpresas(long idUsuario);
    }
}
