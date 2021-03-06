﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SystoqueApplication.Models
{
    public class VendedorModel
    {
        [Key]
        public int Matricula { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        [MaxLength(100,ErrorMessage = "Máximo de 100 caracteres!")]
        public string Nome { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "Obrigatório informar a data de nascimento!")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Datanasc { get; set; }

        [Display(Name = "Comissão")]
        [Required(ErrorMessage = "Obrigatório informar a comissão!")]
        [DisplayFormat(DataFormatString = "{0:P2}", ApplyFormatInEditMode = true)]
        public decimal Comissao { get; set; }
    }
}