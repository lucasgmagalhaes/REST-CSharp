using Entidades.Interfaces;
using System;
using System.Collections.Generic;

namespace Entidades.Entidades.Gerencia
{
    public partial class Empresa : IEntity
    {
        public Empresa()
        {
            this.UsuarioEmpresa = new HashSet<UsuarioEmpresa>();
        }

        public long Id { get; set; }
        public string Nome { get; set; }
        public long IdCliente { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual ICollection<UsuarioEmpresa> UsuarioEmpresa { get; set; }
    }
}
