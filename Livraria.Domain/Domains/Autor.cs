using System.Collections.Generic;

namespace Livraria.Domain.Domains
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public IEnumerable<Livro> Livros { get; set; }
    }
}