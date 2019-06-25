using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SystoqueApplication.Models
{
    public class Item
    {
        [Key]
        public int idItem { get; set; }

        [Display(Name = "Valor Item")]
        [DataType(DataType.Currency)]
        public decimal valorItem { get; set; }

        [Display(Name = "Quantidade Item")]
        [Required(ErrorMessage = "Obrigatório informar a quantidade!")]
        [Range(1, int.MaxValue, ErrorMessage = "Valor informado não é válido")]
        public int qtdItem { get; set; }

        public  Produto produto {get;set;}

        
        public Venda venda { get; set; }

        public Item()
        {
            
        }
       
    }
}