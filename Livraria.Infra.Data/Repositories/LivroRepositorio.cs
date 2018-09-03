using Livraria.Domain.Domains;
using Livraria.Domain.Interfaces;
using Livraria.Infra.Data.Context;

namespace Livraria.Infra.Data.Repositories
{
    public class LivroRepositorio : RepositorioBase<Livro>, ILivro
    { 
        public LivroRepositorio(LivrariaContext context) : base(context)
        {
        }
    }
}