using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Display(Name = "Produto")]
        public string codigoBarra { get; set; }

        public int codVenda { get; set; }

        [ForeignKey("codigoBarra")]
        public virtual List<Produto> produto {get;set;}

        [ForeignKey("codVenda")]
        public virtual Venda venda { get; set; }        
       
    }
}