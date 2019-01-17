using Entidades.Interfaces;
using System;
using System.Collections.Generic;

namespace Entidades.Models
{
    public partial class Cliente : IEntity
    {
        public Cliente()
        {
            Empresa = new HashSet<Empresa>();
        }

        public long Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Empresa> Empresa { get; set; }
    }
}
