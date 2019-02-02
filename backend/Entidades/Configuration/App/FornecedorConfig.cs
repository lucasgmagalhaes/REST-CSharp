using Entidades.Entidades.App;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entidades.Configuration.App
{
    public class FornecedorConfig : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedor");

            builder.Property(entity => entity.Id).ValueGeneratedOnAdd();
            builder.Property(entity => entity.Nome)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(entity => entity.Endereco)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(entity => entity.Estado)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);
        }
    }
}
