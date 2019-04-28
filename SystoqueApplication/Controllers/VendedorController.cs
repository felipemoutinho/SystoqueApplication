using System.Web.Mvc;
using SystoqueApplication.Interfaces;
using SystoqueApplication.Models;

namespace SystoqueApplication.Controllers
{
    public class VendedorController : Controller
    {
        private readonly IVendedorServices _vendedorService;
        public VendedorController(IVendedorServices vendedorServices)
        {
            _vendedorService = vendedorServices;
        }
        
        public ActionResult Index()
        {
            return View(_vendedorService.Lista());
        }

        public ActionResult Details(int id)
        {
            VendedorModel vendedor = new VendedorModel();

            return View(_vendedorService.Selecionar(id));
        }

        public ActionResult Create()
        {
            return View(new VendedorModel());
        }

        [HttpPost]
        public ActionResult Create(VendedorModel vendedor)
        {
            _vendedorService.Incluir(vendedor);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            return View(_vendedorService.Selecionar(id));
        }

        [HttpPost]
        public ActionResult Edit(VendedorModel vendedor)
        {
            _vendedorService.Alterar(vendedor);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            return View(_vendedorService.Selecionar(id));
        }

        [HttpPost]
        public ActionResult Delete(VendedorModel vendedor)
        {
            _vendedorService.Deletar(vendedor);
            return RedirectToAction("Index");
        }
    }
}