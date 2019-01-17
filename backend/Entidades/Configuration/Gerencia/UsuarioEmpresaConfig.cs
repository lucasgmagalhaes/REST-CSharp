using Entidades.Entidades.Gerencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entidades.Configuration.Gerencia
{
    public class UsuarioEmpresaConfig : IEntityTypeConfiguration<UsuarioEmpresa>
    {
        public void Configure(EntityTypeBuilder<UsuarioEmpresa> entity)
        {
            entity.ToTable("Usuario_Empresa");

            entity.HasOne(d => d.IdEmpresaNavigation)
                .WithMany(p => p.UsuarioEmpresa)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Usuario_E__IdEmp__619B8048");

            entity.HasOne(d => d.IdUsuarioNavigation)
                .WithMany(p => p.UsuarioEmpresa)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Usuario_E__IdUsu__628FA481");
        }
    }
}
