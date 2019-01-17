using Entidades.Interfaces;
using System;
using System.Collections.Generic;

namespace Entidades.Entidades.Gerencia
{
    public partial class UsuarioEmpresa : IEntity
    {
        public long Id { get; set; }
        public long IdUsuario { get; set; }
        public long IdEmpresa { get; set; }

        public virtual Empresa IdEmpresaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
