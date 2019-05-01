using SystoqueApplication.Models;

namespace SystoqueApplication.Interfaces
{
    public interface IProdutoNaoPerecivelRepository
    {
        ProdutoNaoPerecivel ConsultarProduto(string codigoBarras);
        void Incluir(ProdutoNaoPerecivel produto);
        void Alterar(ProdutoNaoPerecivel produto);
    }
}
