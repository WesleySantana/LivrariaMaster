using Livraria.Domain.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Livraria.Infra.Data.EntitiesConfigure
{
    public class LivroConfig : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.Property(x => x.Titulo).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Editora).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Edicao).IsRequired();
            builder.HasOne(x => x.Autor)
                .WithMany(a => a.Livros)
                .IsRequired();
        }
    }
}
