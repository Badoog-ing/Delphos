using Delphos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.HtmlControls;
using System.Data.Entity;

namespace Delphos.Areas.Caja.Controllers
{
    public class VentaController : Controller
    {
        // GET: Venta
        private bdSupermercado _db;
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VentaDelDia()
        {
            return View();
        }

        public ActionResult DetalleBoleta()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Buscar(string searchString)
        {            
            _db = new bdSupermercado();
            

            var productos = from b in _db.Productos
                            select b;

            if (!string.IsNullOrEmpty(searchString))
            {
                productos = productos.Where(b => b.Sku.ToString().Contains(searchString));
                
            }

            return View(productos);


        }
    }
}