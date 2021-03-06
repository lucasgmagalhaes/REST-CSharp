﻿using Entidades.Entidades.Gerencia;
using Microsoft.EntityFrameworkCore;

namespace Persistencia.Contexts.Gerencia
{
    public partial class GerenciaContext : DbContext
    {
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
