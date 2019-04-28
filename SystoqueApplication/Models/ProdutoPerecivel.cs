using System;
using System.ComponentModel.DataAnnotations;

namespace SystoqueApplication.Models
{
    public class ProdutoPerecivel: Produto
    {
        [Display(Name = "Data de Validade")]
        [Required(ErrorMessage = "Obrigatório informar a data de validade!")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime dataValidade { get; set; }

        [Display(Name = "Lote Produto")]
        [Required(ErrorMessage = "Obrigatório informar o lote do produto!")]
        [MaxLength(255, ErrorMessage = "Máximo de 255 caracteres!")]
        public string lote { get; set; }

    }
}