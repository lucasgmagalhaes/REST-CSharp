using Entidades.Entidades.Gerencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Configuration.Gerencia
{
    public class EmpresaConfig : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> entity)
        {
            entity.ToTable("Empresa");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Nome)
                               .IsRequired()
                               .HasMaxLength(100)
                               .IsUnicode(false);

            entity.HasOne(d => d.IdClienteNavigation)
                .WithMany(p => p.Empresa)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Empresa__IdClien__6383C8BA");
        }
    }
}
