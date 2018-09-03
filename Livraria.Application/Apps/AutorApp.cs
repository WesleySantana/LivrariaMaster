using Livraria.Application.Interfaces;
using Livraria.Domain.Domains;
using Livraria.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.Application.Apps
{
    public class AutorApp : RepositorioBaseApp<Autor>, IAutorApp
    {
        private readonly IAutor _iAutor;

        public AutorApp(IAutor autor) : base(autor)
        {
            _iAutor = autor;
        }
    }
}
