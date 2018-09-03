using System;
using System.Collections.Generic;

namespace Livraria.Domain.Domains
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime? Ano { get; set; }
        public int Edicao { get; set; }
        public Editora Editora { get; set; }
        public Autor Autor { get; set; }
        public IEnumerable<Assunto> Assuntos { get; set; }
        public int? QtdeEstoque { get; set; }
    }
}