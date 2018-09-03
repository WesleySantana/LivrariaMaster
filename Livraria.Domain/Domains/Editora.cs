using System.Collections.Generic;

namespace Livraria.Domain.Domains
{
    public class Editora
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Livro> Livros { get; set; }
    }
}