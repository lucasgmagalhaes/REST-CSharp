using Entidades.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.EntityConfiguration
{
    public class UsuarioImagemConfiguration : IEntityTypeConfiguration<UsuarioImagem>
    {
        public void Configure(EntityTypeBuilder<UsuarioImagem> entity)
        {
            entity.ToTable("Usuario_Imagem");

            entity.Property(e => e.Imagem)
                  .IsRequired()
                  .HasMaxLength(200);
        }
    }
}
