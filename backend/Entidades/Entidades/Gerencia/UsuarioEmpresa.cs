using Entidades.Interfaces;
using System;
using System.Collections.Generic;

namespace Entidades.Models
{
    public partial class UsuarioEmpresa : IEntity
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public long EmpresaId { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}
