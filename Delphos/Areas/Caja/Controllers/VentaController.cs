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
            List<MetodoPago> MetPago = _db.Metodosdepago.ToList();
            ViewBag.MetoPago = MetPago;
            return View();
        }

        public ActionResult VentaDelDia()
        {
            bdSupermercado _db = new bdSupermercado();
            List<Usuario> usuarios = _db.Usuarios.ToList();
            ViewBag.usuarios = usuarios;
            return View(_db.Ventas.ToList());
        }

        [HttpPost]
        public ActionResult Index(string searchString)
        {
            _db = new bdSupermercado();
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

        public ActionResult DetalleBoleta(int id)
        {
            Venta v = _db.Ventas.Find(id);
            if (v == null)
            {
                return new HttpNotFoundResult();
            }
            List<DetalleBoleta> detalles = _db.DetalleBoletas
                                                .Where(b => b.IdNumeroBoleta == v.NumeroBoleta)
                                                .ToList();
            ViewBag.detalles = detalles;

            List<Producto> productos = _db.Productos.ToList();
            ViewBag.productos = productos;
            return View(v);
        }

    }
}