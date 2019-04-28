using System.ComponentModel.DataAnnotations;

namespace SystoqueApplication.Models
{
    public class ProdutoNaoPerecivel: Produto
    {
        [Display(Name = "Prazo garantia")]
        [Required(ErrorMessage = "Obrigatório informar o prazo de garantia do produto!")]
        [MaxLength(255, ErrorMessage = "Máximo de 255 caracteres!")]
        public string prazoGarantia { get; set; }
    }
}