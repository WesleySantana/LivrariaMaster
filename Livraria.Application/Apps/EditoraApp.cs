using Livraria.Application.Interfaces;
using Livraria.Domain.Domains;
using Livraria.Domain.Interfaces;

namespace Livraria.Application.Apps
{
    public class EditoraApp : RepositorioBaseApp<Editora>, IEditoraApp
    {
        private readonly IEditora _iEditora;

        public EditoraApp(IEditora editora) : base(editora)
        {
            _iEditora = editora;
        }
    }
}
