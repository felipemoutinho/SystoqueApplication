using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SystoqueApplication.Models
{
    public class Item
    {
        [Key]
        public int idItem { get; set; }

        [Display(Name = "Valor Item")]
        public decimal valorItem { get; set; }

        [Display(Name = "Quantidade Item")]
        public int qtdItem { get; set; }

        public  List<Produto> produto {get;set;}

        
        public Venda venda { get; set; }        
       
    }
}