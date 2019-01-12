using Entidades.Interfaces;
using System;
using System.Collections.Generic;

namespace Entidades.Models
{
    public partial class Empresa : IEntity
    {
        public Empresa()
        {
            UsuarioEmpresa = new HashSet<UsuarioEmpresa>();
        }

        public long Id { get; set; }
        public string Nome { get; set; }
        public long ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<UsuarioEmpresa> UsuarioEmpresa { get; set; }
    }
}
