using System.Collections.Generic;
using System.Web.Mvc;
using SystoqueApplication.Interfaces;
using SystoqueApplication.Models;

namespace SystoqueApplication.Controllers
{
    public class ItemController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
    }
}