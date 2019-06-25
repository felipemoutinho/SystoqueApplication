using System.Collections.Generic;
using System.Data;
using SystoqueApplication.Interfaces;
using SystoqueApplication.Models;
using SystoqueApplication.Util;

namespace SystoqueApplication.Repository
{
    public class ItemRepository : IItemRepository
    {

        private static List<Item> listaItens;

        public ItemRepository()
        {
            if (listaItens == null)
                listaItens = new List<Item>();
        }


        public void Excluir(Item item)
        {
            throw new System.NotImplementedException();
        }

        public decimal TotalVenda()
        {
            decimal total = 0;
            foreach(var item in listaItens)
            {
                total = total + item.valorItem;
            }
            return total;
        }


        public List<Item> Incluir(string codigoProduto, int qtdItem)
        {
            string sql = $"select * from tblproduto where cb = '{codigoProduto}'";
            AcessoBD acesso = new AcessoBD();
            DataTable dt = acesso.Consulta(sql);
            Item item = new Item();

            if (dt.Rows.Count == 1)
            {
                if (listaItens.Exists(i => i.produto.codigoBarra == codigoProduto))
                {
                    var elemento = listaItens.Find(i => i.produto.codigoBarra == codigoProduto);
                    elemento.qtdItem++;
                    elemento.valorItem = elemento.qtdItem * elemento.produto.valorVenda;
                }
                else
                {
                    item.qtdItem = qtdItem;
                    if (dt.Rows[0]["PrazoGarantia"].ToString() != "")
                    {
                        item.produto = new ProdutoNaoPerecivel();
                        item.produto.codigoBarra = dt.Rows[0]["cb"].ToString();
                        item.produto.nomeProduto = dt.Rows[0]["nomeproduto"].ToString();
                        item.produto.valorVenda = decimal.Parse(dt.Rows[0]["valorvenda"].ToString());
                        item.produto.qtdeProduto = int.Parse(dt.Rows[0]["qtdprod"].ToString());
                        item.produto.qtdeMinProduto = int.Parse(dt.Rows[0]["qtdminprod"].ToString());
                        item.valorItem = item.qtdItem * item.produto.valorVenda;
                    }
                    else
                    {
                        item.produto = new ProdutoPerecivel();
                        item.produto.codigoBarra = dt.Rows[0]["cb"].ToString();
                        item.produto.nomeProduto = dt.Rows[0]["nomeproduto"].ToString();
                        item.produto.valorVenda = decimal.Parse(dt.Rows[0]["valorvenda"].ToString());
                        item.produto.qtdeProduto = int.Parse(dt.Rows[0]["qtdprod"].ToString());
                        item.produto.qtdeMinProduto = int.Parse(dt.Rows[0]["qtdminprod"].ToString());
                        item.valorItem = item.qtdItem * item.produto.valorVenda;
                    }
                    listaItens.Add(item);
                }
                
                return listaItens;
            }
            else return null;
            
        }
    }
}