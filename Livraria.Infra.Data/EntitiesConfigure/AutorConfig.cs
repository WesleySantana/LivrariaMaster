using Livraria.Domain.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Livraria.Infra.Data.EntitiesConfigure
{
    public class AutorConfig : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> builder)
        {
            builder.Property(x => x.Nome).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Sobrenome).HasMaxLength(100);
            builder.HasMany(x => x.Livros).WithOne(l => l.Autor);
        }       
    }
}
