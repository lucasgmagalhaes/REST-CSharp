using Entidades.Interfaces;
using System;
using System.Collections.Generic;

namespace Entidades.Models
{
    public partial class UsuarioImagem : IEntity
    {
        public long Id { get; set; }
        public byte[] Imagem { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
