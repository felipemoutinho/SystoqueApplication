using System.ComponentModel.DataAnnotations;

namespace SystoqueApplication.Models
{
    public abstract class Produto
    {
        [Key]
        [Display(Name = "Código de Barras")]
        [Required(ErrorMessage = "Obrigatório informar o código de barras!")]
        [MaxLength(255, ErrorMessage = "Máximo de 255 caracteres!")]
        public string codigoBarra { get; set; }

        [Display(Name = "Nome Produto")]
        [Required(ErrorMessage = "Obrigatório informar o nome do produto!")]
        [MaxLength(255, ErrorMessage = "Máximo de 255 caracteres!")]
        public string nomeProduto { get; set; }

        [Display(Name = "Valor de Venda")]
        [Required(ErrorMessage = "Obrigatório informar o valor de venda!")]
        [DataType(DataType.Currency)]
        public decimal valorVenda { get; set; }

        [Display(Name = "Quantidade")]
        [Required(ErrorMessage = "Obrigatório informar a quantidade!")]
        [Range(1,int.MaxValue,ErrorMessage ="Valor informado não é válido")]
        public int qtdeProduto { get; set; }

        [Display(Name = "Quantidade Mínima")]
        [Required(ErrorMessage = "Obrigatório informar a quantidade mínima!")]
        [Range(1, int.MaxValue, ErrorMessage = "Valor informado não é válido")]
        public int qtdeMinProduto { get; set; }

        
    }
}