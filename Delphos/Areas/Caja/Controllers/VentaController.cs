using Delphos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
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

            List<Producto> productos = _db.Productos.ToList();
            ViewBag.productos = productos;

            List<Producto> data = _db.Productos.ToList();
            SelectList lista = new SelectList(data, "Id", "Nombre");
            ViewBag.ListaProducto = lista;

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
        public JsonResult busqueda(string searchString)
        {
            _db = new bdSupermercado();
            var lista = new List<Producto>();
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

                    /*lista.Add(d);*/

                }
                if (productos.Count() == 0)
                {
                    /*falta mostrar mensaje de que no se encontro el producto*/
                    /*return Content("El producto no se encuentra");*/
                }
            }

           /* return Json(productos, JsonRequestBehavior.AllowGet);*/
            return Json(ViewBag.Nombre);
        }

        public ActionResult DetalleBoleta(int id)
        {
            Venta v = _db.Ventas.Find(id);
            if (v == null)
            {
                return new HttpNotFoundResult();
            }
            List<DetalleBoleta> detalles = _db.DetalleBoletas.ToList();
            ViewBag.detalles = detalles;

            List<Producto> productos = _db.Productos.ToList();
            ViewBag.productos = productos;
            return View(v);
        }


        public JsonResult ObtenerProducto(int Sku)
        {
            List<Producto> p = _db.Productos.Where(pr => pr.Sku == Sku).ToList();
                
            return Json(p, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Seleccionar(string idProducto)
        {
            int id = Int32.Parse(idProducto);
            Producto objProducto = _db.Productos.Find(id);
            _db.Productos.Find(objProducto);
            return Json(objProducto, JsonRequestBehavior.AllowGet);

        }

        public JsonResult List()
        {
            List<Producto> p = _db.Productos.ToList();

            return Json(p, JsonRequestBehavior.AllowGet);
        }

    }
}