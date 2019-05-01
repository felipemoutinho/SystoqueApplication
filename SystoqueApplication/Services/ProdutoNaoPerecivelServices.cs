using System;
using SystoqueApplication.Interfaces;
using SystoqueApplication.Models;

namespace SystoqueApplication.Services
{
    public class ProdutoNaoPerecivelServices : IProdutoNaoPerecivelServices
    {
        private readonly IProdutoNaoPerecivelRepository _produtoNaoPerecivelRepository;

        public ProdutoNaoPerecivelServices(IProdutoNaoPerecivelRepository produtoNaoPerecivelRepository)
        {
            _produtoNaoPerecivelRepository = produtoNaoPerecivelRepository;
        }
        public void Alterar(ProdutoNaoPerecivel produto)
        {
            _produtoNaoPerecivelRepository.Alterar(produto);
        }

        public ProdutoNaoPerecivel ConsultarProduto(string codigoBarras)
        {
           return _produtoNaoPerecivelRepository.ConsultarProduto(codigoBarras);
        }

        public void Incluir(ProdutoNaoPerecivel produto)
        {
            _produtoNaoPerecivelRepository.Incluir(produto);
        }
    }
}