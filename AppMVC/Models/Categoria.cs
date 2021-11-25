using System.ComponentModel.DataAnnotations;

namespace AppMVC.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        public string Descricao { get; set; }

        public List<Produto> Produtos { get; set; }

    }
}
