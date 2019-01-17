using Entidades.Entidades.Gerencia;
using System.Collections.Generic;

namespace Persistencia.Interfaces
{
    public interface IUsuarioEmpresaService : ICrudService<UsuarioEmpresa>
    {
        List<UsuarioEmpresa> BuscarPorIdUsuario(long id);
        List<UsuarioEmpresa> BuscarPorIdEmpresa(long id);
        List<Usuario> BuscarUsuariosPorIdEmpresa(long id);
        List<Empresa> BuscarEmpresasPorIdUsuario(long id);
    }
}
