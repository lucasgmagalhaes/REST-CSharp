using System.Collections.Generic;
using System.Linq;
using Entidades.Entidades.Gerencia;
using Microsoft.EntityFrameworkCore;
using Persistencia.Contexts.Gerencia;
using Persistencia.Interfaces;

namespace Persistencia.Services
{
    public class UsuarioEmpresaService : CrudService<UsuarioEmpresa>, IUsuarioEmpresaService
    {
        public UsuarioEmpresaService(GerenciaContext dbContext) : base(dbContext) { }

        public List<UsuarioEmpresa> BuscarPorIdEmpresa(long id)
        {
            return base.Buscar(usuarioEmpresa => usuarioEmpresa.IdEmpresa == id).ToList();
        }

        public List<UsuarioEmpresa> BuscarPorIdUsuario(long id)
        {
            return base.Buscar(usuarioEmpresa => usuarioEmpresa.IdUsuario == id).ToList();
        }

        public List<Empresa> BuscarEmpresasPorIdUsuario(long id)
        {
            return base.Buscar(usuarioEmpresa => usuarioEmpresa.IdUsuario == id,
                r => r.Include(c => c.IdEmpresaNavigation))
                .Select(usuarioEmpresa => usuarioEmpresa.IdEmpresaNavigation).ToList();
        }

        public List<Usuario> BuscarUsuariosPorIdEmpresa(long id)
        {
            return base.Buscar(usuarioEmpresa => usuarioEmpresa.IdUsuario == id,
                r => r.Include(c => c.IdUsuarioNavigation))
                .Select(usuarioEmpresa => usuarioEmpresa.IdUsuarioNavigation).ToList();
        }
    }
}
