using System.Web.Mvc;
using SystoqueApplication.Interfaces;
using SystoqueApplication.Models;

namespace SystoqueApplication.Controllers
{
    public class ProdutoPerecivelController : Controller
    {
        private readonly IProdutoPerecivelServices _produtoPerecivelServices;

        public ProdutoPerecivelController(IProdutoPerecivelServices produtoPerecivelServices)
        {
            _produtoPerecivelServices = produtoPerecivelServices;
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProdutoPerecivel produtoPerecivel)
        {
            if (ModelState.IsValid)
            {
                _produtoPerecivelServices.Incluir(produtoPerecivel);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Error");
            }
        }

        public ActionResult Index(string codigoBarras)
        {
            if(codigoBarras == null)
            {
                return View();
            }
            return View(_produtoPerecivelServices.ConsultarProduto(codigoBarras));
        }

        [HttpPost]
        public ActionResult Index(ProdutoPerecivel produto)
        {
            if (ModelState.IsValid)
            {
                _produtoPerecivelServices.Alterar(produto);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Error");
            }
        }

    }
}