using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
        // GET: Vendedor
        public ActionResult Index()
        {
            return View(_vendedorService.Lista());
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
    }
}