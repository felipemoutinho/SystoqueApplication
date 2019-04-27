

namespace SystoqueApplication.Models
{
    public abstract class Produto
    {
        public string codigoBarra { get; set; }
        public string nomeProduto { get; set; }
        public decimal valorVenda { get; set; }

        public int qtdeProduto { get; set; }

        public int qtdeMinProduto { get; set; }

        
    }
}