using Entidades.Models;
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
            entity.Property(e => e.ClienteId).HasColumnName("Cliente_Id");

            entity.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Cliente)
                .WithMany(p => p.Empresa)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK__Empresa__Cliente");
        }
    }
}
