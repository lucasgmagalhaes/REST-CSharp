using Entidades.Interfaces;
using System;
using System.Collections.Generic;

namespace Entidades.Entidades.Gerencia
{
    public partial class Usuario : IEntity
    {
        public Usuario()
        {
            this.UsuarioEmpresa = new HashSet<UsuarioEmpresa>();
        }

        public long Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual ICollection<UsuarioEmpresa> UsuarioEmpresa { get; set; }
    }
}
