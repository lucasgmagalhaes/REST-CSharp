using Entidades.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistencia.Configuration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> entity)
        {
            entity.ToTable("Usuario");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Senha)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Sobrenome)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.UsuarioImagem).HasColumnName("Usuario_Imagem");

            entity.HasOne(d => d.IdNavigation)
                .WithOne(p => p.Usuario)
                .HasForeignKey<Usuario>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usuario_Imagem");
        }
    }
}
