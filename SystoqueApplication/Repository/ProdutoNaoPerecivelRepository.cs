using System.Data;
using SystoqueApplication.Interfaces;
using SystoqueApplication.Models;
using SystoqueApplication.Util;

namespace SystoqueApplication.Repository
{
    public class ProdutoNaoPerecivelRepository : IProdutoNaoPerecivelRepository
    {
        public void Alterar(ProdutoNaoPerecivel produto)
        {
            string sql = $"update tblproduto set nomeproduto = '{produto.nomeProduto}',valorvenda = {produto.valorVenda}, qtdprod = {produto.qtdeProduto},qtdminprod = {produto.qtdeMinProduto} ," +
                $" prazogarantia = '{produto.prazoGarantia}'" +
                $" where cb = {produto.codigoBarra} and datavalidade is null and lote is null";
            AcessoBD acesso = new AcessoBD();
            acesso.ComandoSQL(sql);
        }

        public ProdutoNaoPerecivel ConsultarProduto(string codigoBarras)
        {
            ProdutoNaoPerecivel produto;
            string sql = $"select cb,nomeproduto,valorvenda,qtdprod,qtdminprod,PrazoGarantia from tblproduto where cb = '{codigoBarras}'" +
                $" and datavalidade is null and lote is null";
            AcessoBD acesso = new AcessoBD();
            DataTable dt = acesso.Consulta(sql);

            if (dt.Rows.Count > 0)
            {
                produto = new ProdutoNaoPerecivel();
                produto.codigoBarra = dt.Rows[0]["cb"].ToString();
                produto.nomeProduto = dt.Rows[0]["nomeproduto"].ToString();
                produto.valorVenda = decimal.Parse(dt.Rows[0]["valorvenda"].ToString());
                produto.qtdeProduto = int.Parse(dt.Rows[0]["qtdprod"].ToString());
                produto.qtdeMinProduto = int.Parse(dt.Rows[0]["qtdminprod"].ToString());
                produto.prazoGarantia = dt.Rows[0]["PrazoGarantia"].ToString();

                return produto;
            }
            return produto = null;
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