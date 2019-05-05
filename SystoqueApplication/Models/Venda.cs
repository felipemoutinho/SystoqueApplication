using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SystoqueApplication.Models
{
    public class Venda
    {
        [Key]
        public int codVenda { get; set; }

        [Display(Name ="Data Venda")]
        [Required(ErrorMessage = "Obrigatório informar a data da venda!")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime dataVenda { get; set; }

        [Display(Name = "Data Previsão Entrega")]
        [Required(ErrorMessage = "Obrigatório informar a data previsão de entrega!")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
         public DateTime dataPrevEntrega { get; set; }

        [Display(Name = "Total Venda")]
        public decimal totalVenda { get; set; }

        [Display(Name = "Status Venda")]
        public string statusVenda { get; set; }

        [Display(Name = "Vendedor")]
        [Required(ErrorMessage = "Informar o vendedor")]
        public  VendedorModel vendedor { get; set; }

    }
}