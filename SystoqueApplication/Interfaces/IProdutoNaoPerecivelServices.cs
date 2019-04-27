using SystoqueApplication.Models;

namespace SystoqueApplication.Interfaces
{
    public interface IProdutoNaoPerecivelServices
    {
        ProdutoNaoPerecivel ConsultarProduto();
        void Incluir(ProdutoNaoPerecivel produto);
        void Alterar(ProdutoNaoPerecivel produto);
    }
}
