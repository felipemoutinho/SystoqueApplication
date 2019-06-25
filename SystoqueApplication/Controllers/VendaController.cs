using System.Web.Mvc;
using SystoqueApplication.Models;
using SystoqueApplication.Interfaces;
using System.Collections.Generic;

namespace SystoqueApplication.Controllers
{
    public class VendaController : Controller
    {
        private readonly IVendedorServices _vendedorService;
        private readonly IItemService _itemService;
        private List<Item> lista;
        public VendaController(IVendedorServices vendedorService, IItemService itemService)
        {
            _vendedorService = vendedorService;
            _itemService = itemService;
        }
        
       

        public ActionResult Create()
        {
            ViewBag.ListaVendedores = _vendedorService.Lista();
            return View(new Item());
        }

        [HttpPost]
        public ActionResult Create(Item Itensvenda)
        {
            Itensvenda.venda.totalVenda = _itemService.TotalVenda();
            return RedirectToAction("Create");
        }

        
        public PartialViewResult ListarItens(string codigoProduto = "", int qtdItem = 1)
        {
            if (Request.IsAjaxRequest())
            {
                lista = _itemService.Incluir(codigoProduto, qtdItem);
                return PartialView("_ListItens", lista);
            }
            else return PartialView();
        }
    }
}