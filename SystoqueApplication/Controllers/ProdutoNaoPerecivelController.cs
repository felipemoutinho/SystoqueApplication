using System.Web.Mvc;
using SystoqueApplication.Interfaces;
using SystoqueApplication.Models;

namespace SystoqueApplication.Controllers
{
    public class ProdutoNaoPerecivelController : Controller
    {
        private readonly IProdutoNaoPerecivelServices _produtoNaoPerecivelServices;

        public ProdutoNaoPerecivelController(IProdutoNaoPerecivelServices produtoNaoPerecivelServices)
        {
            _produtoNaoPerecivelServices = produtoNaoPerecivelServices;
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProdutoNaoPerecivel produto)
        {
            if (ModelState.IsValid)
            {
                _produtoNaoPerecivelServices.Incluir(produto);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Error");
            }
        }

        public ActionResult Index(string codigoBarras)
        {
            if (codigoBarras == null)
            {
                return View();
            }
            return View(_produtoNaoPerecivelServices.ConsultarProduto(codigoBarras));
        }

        [HttpPost]
        public ActionResult Index(ProdutoNaoPerecivel produto)
        {
            if (ModelState.IsValid)
            {
                _produtoNaoPerecivelServices.Alterar(produto);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Error");
            }
        }
    }
}