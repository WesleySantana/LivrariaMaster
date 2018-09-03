using Livraria.Domain.Domains;
using Livraria.Domain.Interfaces;
using Livraria.Infra.Data.Context;

namespace Livraria.Infra.Data.Repositories
{
    public class EditoraRepositorio : RepositorioBase<Editora>, IEditora
    {
        public EditoraRepositorio(LivrariaContext context) : base(context)
        {
        }
    }
}