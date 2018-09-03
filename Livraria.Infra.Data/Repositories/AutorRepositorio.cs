using Livraria.Domain.Domains;
using Livraria.Domain.Interfaces;
using Livraria.Infra.Data.Context;

namespace Livraria.Infra.Data.Repositories
{
    public class AutorRepositorio : RepositorioBase<Autor>, IAutor
    {
        public AutorRepositorio(LivrariaContext context) : base(context)
        {
        }
    }
}