using Entidades.Interfaces;
using System;
using System.Collections.Generic;

namespace Entidades.Models
{
    public partial class Empresa : IEntity
    {
        public Empresa()
        {
            UsuarioEmpresa = new HashSet<Usuario>();
        }

        public long Id { get; set; }
        public string Nome { get; set; }
        public long ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<Usuario> UsuarioEmpresa { get; set; }
    }
}
