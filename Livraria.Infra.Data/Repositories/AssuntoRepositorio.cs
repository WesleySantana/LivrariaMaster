using Livraria.Domain.Domains;
using Livraria.Domain.Interfaces;
using Livraria.Infra.Data.Context;

namespace Livraria.Infra.Data.Repositories
{
    public class AssuntoRepositorio : RepositorioBase<Assunto>, IAssunto
    {
        public AssuntoRepositorio(LivrariaContext context) : base(context)
        {
        }
    }
}