using Livraria.Domain.Domains;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Livraria.Application.ViewModels
{
    public class EditoraViewModel
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Livro> Livros { get; set; }
    }
}
