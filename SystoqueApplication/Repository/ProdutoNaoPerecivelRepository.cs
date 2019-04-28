using SystoqueApplication.Interfaces;
using SystoqueApplication.Models;
using SystoqueApplication.Util;

namespace SystoqueApplication.Repository
{
    public class ProdutoNaoPerecivelRepository : IProdutoNaoPerecivelRepository
    {
        public void Alterar(ProdutoNaoPerecivel produto)
        {
            throw new System.NotImplementedException();
        }

        public ProdutoNaoPerecivel ConsultarProduto()
        {
            throw new System.NotImplementedException();
        }

        public void Incluir(ProdutoNaoPerecivel produto)
        {
            string sql = $"insert into tblproduto (cb,nomeproduto,valorvenda,qtdprod,qtdminprod,PrazoGarantia) values ('{produto.codigoBarra}', '{produto.nomeProduto}'," +
                $"{produto.valorVenda},{produto.qtdeProduto},{produto.qtdeMinProduto},'{produto.prazoGarantia}')";
            AcessoBD acesso = new AcessoBD();
            acesso.ComandoSQL(sql);
        }
    }
}