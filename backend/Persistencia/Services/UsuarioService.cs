using Entidades.Entidades.Gerencia;
using Microsoft.EntityFrameworkCore;
using Persistencia.Contexts.Gerencia;
using Persistencia.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Persistencia.Services
{
    public class UsuarioService : CrudService<Usuario>, IUsuarioService
    {
        private IUsuarioEmpresaService usuarioEmpresaService;
        public UsuarioService(GerenciaContext dbContext, IUsuarioEmpresaService usuarioEmpresaService) : base(dbContext)
        {
            this.usuarioEmpresaService = usuarioEmpresaService;
        }

        public List<Empresa> BuscarEmpresas(long idUsuario)
        {
            Usuario usuario = base.Buscar(user => user.Id == idUsuario).SingleOrDefault();
            return this.usuarioEmpresaService.BuscarEmpresasPorIdUsuario(usuario.Id);
        }
    }
}
