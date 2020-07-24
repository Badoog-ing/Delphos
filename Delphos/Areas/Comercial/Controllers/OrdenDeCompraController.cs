using Delphos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Delphos.Areas.Comercial.Controllers
{
    public class OrdenDeCompraController : Controller
    {
        private bdSupermercado _db = new bdSupermercado();

        // GET: OrdenDeCompra
        [HttpGet]
        public ActionResult Index()
        {
            List<OrdenCompra> ordenCompras = _db.OrdenCompras.ToList();
            return View(ordenCompras);
        }
        [HttpGet]
        public ActionResult Nuevo()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Ver(int id)
        {
            OrdenCompra orden = _db.OrdenCompras.Find(id);
            if (orden == null)
            {
                return new HttpNotFoundResult();
            }

            return View(orden);
        }
        [HttpGet]
        public ActionResult Editar(int id)
        {
            return View();
        }
        public ActionResult AgregarProducto()
        {
            return View();
        }
    }
}