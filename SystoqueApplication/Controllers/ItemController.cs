using System.Collections.Generic;
using System.Web.Mvc;
using SystoqueApplication.Interfaces;
using SystoqueApplication.Models;

namespace SystoqueApplication.Controllers
{
    public class ItemController : Controller
    {
        private readonly IVendedorServices _vendedorService;
        private readonly IProdutoPerecivelServices _produtoPerecivelServices;
        private readonly IProdutoNaoPerecivelServices _produtoNaoPerecivelServices;


        public ItemController(IVendedorServices vendedorService, IProdutoPerecivelServices produtoPerecivelServices, IProdutoNaoPerecivelServices produtoNaoPerecivelServices)
        {
            _vendedorService = vendedorService;
            _produtoPerecivelServices = produtoPerecivelServices;
            _produtoNaoPerecivelServices = produtoNaoPerecivelServices;
        }
        // GET: Item
        public ActionResult RegistroVenda()
        {
            ViewBag.ListaVendedores = new SelectList(_vendedorService.Lista(), "Matricula", "Nome");
            return View(new Item());
        }

        public ActionResult PesquisarProduto()
        {
            if (Request.IsAjaxRequest())
            {
                Item item = new Item();
                Produto p = new ProdutoNaoPerecivel
                {
                    codigoBarra = "222",
                    nomeProduto = "teste",
                    qtdeProduto = 100,
                    qtdeMinProduto = 10,
                    prazoGarantia = "teste",
                    valorVenda = 4
                };
                item.qtdItem = 4;
                item.produto = new List<Produto>();
                item.produto.Add(p);
                return PartialView("_Produtos", item);
            }
            else
            {
                return PartialView("_Produtos", new Item());
            }
        }



    }
}