using Delphos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Delphos.Areas.Comercial.Controllers
{
    public class ProveedorController : Controller
    {
        private bdSupermercado _db = new bdSupermercado();

        // GET: Proveedor
        [HttpGet]
        public ActionResult Index()
        {
            //list de model Proveedor
            //select * from Proveedores
            List<Proveedor> proveedores = _db.Proveedores.ToList();
            return View(proveedores);
        }
        [HttpGet]
        public ActionResult Nuevo()
        {
            //objeto pro de la clase Proveedor
            Proveedor pro = new Proveedor();
            return View(pro);
        }
        public ActionResult Nuevo(Proveedor pro)
        {
            if (ModelState.IsValid)
            {
                _db = new bdSupermercado();
                _db.Proveedores.Add(pro);
                _db.SaveChanges();
                Request.Flash("success", "Proveedor agregado con exito !!!");
                return RedirectToAction("Index", "Proveedor");
            }
            else
            {
                return View(pro);
            }
        }
        [HttpGet]
        public ActionResult Ver(int id)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Editar(int id)
        {
            return View();
        }
    }
}