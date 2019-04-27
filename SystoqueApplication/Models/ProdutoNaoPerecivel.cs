using System;


namespace SystoqueApplication.Models
{
    public class ProdutoNaoPerecivel: Produto
    {
        public string prazoGarantia { get; set; }
    }
}