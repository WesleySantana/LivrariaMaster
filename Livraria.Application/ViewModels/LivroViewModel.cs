using Livraria.Domain.Domains;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Livraria.Application.ViewModels
{
    public class LivroViewModel
    {
        [ScaffoldColumn(false)]
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
