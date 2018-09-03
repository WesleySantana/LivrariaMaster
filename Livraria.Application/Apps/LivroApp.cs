using Livraria.Application.Interfaces;
using Livraria.Domain.Domains;
using Livraria.Domain.Interfaces;

namespace Livraria.Application.Apps
{

    public class LivroApp : RepositorioBaseApp<Livro>, ILivroApp
    {
        private readonly ILivro _iLivro;

        public LivroApp(ILivro livro) : base(livro)
        {
            _iLivro = livro;
        }
    }
}
