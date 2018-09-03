using System.ComponentModel.DataAnnotations;

namespace Livraria.Application.ViewModels
{
    public class AssuntoViewModel
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
