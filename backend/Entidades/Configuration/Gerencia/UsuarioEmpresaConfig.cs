using Entidades.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entidades.Configuration.Gerencia
{
    public class UsuarioEmpresaConfig : IEntityTypeConfiguration<UsuarioEmpresa>
    {
        public void Configure(EntityTypeBuilder<UsuarioEmpresa> entity)
        {
            entity.ToTable("Usuario_Empresa");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.EmpresaId).HasColumnName("Empresa_Id");

            entity.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Senha)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.Empresa)
                .WithMany(p => p.UsuarioEmpresa)
                .HasForeignKey(d => d.EmpresaId)
                .HasConstraintName("FK__Usuario_E__Empre__46E78A0C");
        }
    }
}
