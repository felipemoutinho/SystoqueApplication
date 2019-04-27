using SystoqueApplication.Models;

namespace SystoqueApplication.Interfaces
{
    public interface IProdutoPerecivelRepository
    {
        ProdutoPerecivel ConsultarProduto();

        void Incluir(ProdutoPerecivel produto);

        void Alterar(ProdutoPerecivel produto);
    }
}
