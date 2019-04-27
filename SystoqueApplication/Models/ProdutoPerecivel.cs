using System;


namespace SystoqueApplication.Models
{
    public class ProdutoPerecivel: Produto
    {
        public DateTime dataValidade { get; set; }
        public string lote { get; set; }

    }
}