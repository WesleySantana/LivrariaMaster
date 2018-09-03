using Livraria.Application.Interfaces;
using Livraria.Domain.Domains;
using Livraria.Domain.Interfaces;

namespace Livraria.Application.Apps
{
    public class AssuntoApp : RepositorioBaseApp<Assunto>, IAssuntoApp
    {
        private readonly IAssunto _iAssunto;

        public AssuntoApp(IAssunto assunto) : base(assunto)
        {
            _iAssunto = assunto;
        }
    }
}
