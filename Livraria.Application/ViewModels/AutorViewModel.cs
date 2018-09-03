using Livraria.Domain.Domains;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Livraria.Application.ViewModels
{
    public class AutorViewModel
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public IEnumerable<Livro> Livros { get; set; }
    }
}
