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
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Error");
            }
        }
    }
}