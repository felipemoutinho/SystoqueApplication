using SystoqueApplication.Models;

namespace SystoqueApplication.Interfaces
{
    public interface IProdutoNaoPerecivelRepository
    {
        ProdutoNaoPerecivel ConsultarProduto();
        void Incluir(ProdutoNaoPerecivel produto);
        void Alterar(ProdutoNaoPerecivel produto);
    }
}
