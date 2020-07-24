using Delphos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Delphos.Areas.Caja.Controllers
{
    
    public class VentaController : Controller
    {
        // GET: Venta
        bdSupermercado _db = new bdSupermercado();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VentaDelDia()
        {
            bdSupermercado _db = new bdSupermercado();
            return View(_db.Ventas.ToList());
        }

        [HttpPost]
        public ActionResult Index(string searchString)
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
                    ViewBag.Nombre = d.Nombre;
                    ViewBag.Sku = d.Sku;
                    ViewBag.Precio = d.Precio;
                }
                if (productos.Count() == 0)
                {
                    /*falta mostrar mensaje de que no se encontro el producto*/
                    /*return Content("El producto no se encuentra");*/
                }
            }
            return View(productos);
        }

        [HttpPost]
        public ActionResult AgregarVenta(string searchString) // creo que deberia ser algo asi cambiando el valor que se envia
        {
            _db = new bdSupermercado();
            Producto p = new Producto();
            var productos = from b in _db.Productos
                            select b;

            if (!string.IsNullOrEmpty(searchString))
            {
                productos = productos.Where(b => b.Sku.ToString().Contains(searchString));
                List<Producto> listaV = new List<Producto>();
                foreach (var d in productos)
                {
                    listaV.Add(d);
                }
                
            }
            return View(productos);
        }

        public ActionResult DetalleBoleta(int id)
        {
            Venta v = _db.Ventas.Find(id);
            if (v == null)
            {
                return new HttpNotFoundResult();
            }
            return View(v);
        }

    }
}