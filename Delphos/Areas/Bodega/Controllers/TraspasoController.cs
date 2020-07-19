using Delphos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Delphos.Areas.Bodega.Controllers
{
    public class TraspasoController : Controller
    {
        private bdSupermercado _db;

        // GET: Traspaso
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detalles()
        {
            return View();
        }

        public ActionResult Crear(string searchString)
        {
            _db = new bdSupermercado();
            Producto p = new Producto();
            var productos = from b in _db.Productos
                            select b;

            if (!string.IsNullOrEmpty(searchString))
            {
                productos = productos.Where(b => b.Sku.ToString().Contains(searchString));
                    foreach (var d in productos)
                    {
                        ViewBag.Id = d.Id;
                        ViewBag.Nombre = d.Nombre;
                        ViewBag.Sku = d.Sku;
                        ViewBag.Precio = d.Precio;
                    }
                    if(productos.Count() == 0)
                    {
                        /*falta mostrar un mensaje de que no se encontro el producto*/
                        /*return Content("El producto no se encuentra");*/                    
                    }
            }
            return View(productos);
        }

    }
}