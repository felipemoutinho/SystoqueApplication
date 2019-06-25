using System;
using System.Data;
using SystoqueApplication.Interfaces;
using SystoqueApplication.Models;
using SystoqueApplication.Util;

namespace SystoqueApplication.Repository
{
    public class ProdutoPerecivelRepository : IProdutoPerecivelRepository
    {
        public void Alterar(ProdutoPerecivel produto)
        {
            string sql = $"update tblproduto set nomeproduto = '{produto.nomeProduto}',valorvenda = {produto.valorVenda}, qtdprod = {produto.qtdeProduto},qtdminprod = {produto.qtdeMinProduto} ," +
                $" DataValidade = '{produto.dataValidade.ToString("yyyy/MM/dd")}', lote = '{produto.lote}'" +
                $" where cb = {produto.codigoBarra} and prazogarantia is null";
            AcessoBD acesso = new AcessoBD();
            acesso.ComandoSQL(sql);
        }

        public ProdutoPerecivel ConsultarProduto(string codigoBarras)
        {
            ProdutoPerecivel produto;
            string sql = $"select cb,nomeproduto,valorvenda,qtdprod,qtdminprod,DataValidade,Lote from tblproduto where cb = '{codigoBarras}'" +
                $" and prazogarantia is null";
            AcessoBD acesso = new AcessoBD();
            DataTable dt = acesso.Consulta(sql);

            if (dt.Rows.Count > 0)
            {
                produto = new ProdutoPerecivel();
                produto.codigoBarra = dt.Rows[0]["cb"].ToString();
                produto.nomeProduto = dt.Rows[0]["nomeproduto"].ToString();
                produto.valorVenda = decimal.Parse(dt.Rows[0]["valorvenda"].ToString());
                produto.qtdeProduto = int.Parse(dt.Rows[0]["qtdprod"].ToString());
                produto.qtdeMinProduto = int.Parse(dt.Rows[0]["qtdminprod"].ToString());
                produto.dataValidade = DateTime.Parse(dt.Rows[0]["DataValidade"].ToString());
                produto.lote = dt.Rows[0]["Lote"].ToString();

                return produto;
            }
            return null;
        }

        public void Incluir(ProdutoPerecivel produto)
        {
            string sql = $"insert into tblproduto (cb,nomeproduto,valorvenda,qtdprod,qtdminprod,DataValidade,Lote) values ('{produto.codigoBarra}', '{produto.nomeProduto}'," +
                $"{produto.valorVenda},{produto.qtdeProduto},{produto.qtdeMinProduto},'{produto.dataValidade.ToString("yyyy/MM/dd")}','{produto.lote}')";
            AcessoBD acesso = new AcessoBD();
            acesso.ComandoSQL(sql);
        }
    }
}