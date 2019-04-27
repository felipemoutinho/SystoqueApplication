using SystoqueApplication.Interfaces;
using SystoqueApplication.Models;

namespace SystoqueApplication.Services
{
    public class ProdutoPerecivelServices : IProdutoPerecivelServices
    {
        private readonly IProdutoPerecivelRepository _produtoPerecivelRepository;

        public ProdutoPerecivelServices(IProdutoPerecivelRepository produtoPerecivelRepository)
        {
            _produtoPerecivelRepository = produtoPerecivelRepository;
        }
        public void Alterar(ProdutoPerecivel produto)
        {
            throw new System.NotImplementedException();
        }

        public ProdutoPerecivel ConsultarProduto()
        {
            throw new System.NotImplementedException();
        }

        public void Incluir(ProdutoPerecivel produto)
        {
            throw new System.NotImplementedException();
        }
    }
}