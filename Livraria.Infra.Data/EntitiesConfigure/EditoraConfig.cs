using Livraria.Domain.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Livraria.Infra.Data.EntitiesConfigure
{
    public class EditoraConfig : IEntityTypeConfiguration<Editora>
    {
        public void Configure(EntityTypeBuilder<Editora> builder)
        {
            builder.Property(x => x.Nome).HasMaxLength(50).IsRequired();
            builder.HasMany(x => x.Livros).WithOne(l => l.Editora);
        }        
    }
}
