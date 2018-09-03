using Livraria.Domain.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Livraria.Infra.Data.EntitiesConfigure
{
    class AssuntoConfig : IEntityTypeConfiguration<Assunto>
    {
        public void Configure(EntityTypeBuilder<Assunto> builder)
        {
            builder.Property(x => x.Descricao).HasMaxLength(50).IsRequired();
        }        
    }
}
