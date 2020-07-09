using Delphos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Delphos.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
            private bdSupermercado _db;
            public ActionResult Index()
            {
                IEnumerable<Producto> productos = null;
                _db = new bdSupermercado();
                productos = _db.Productos.ToList();
                return View(productos);
            }
            public ActionResult Nuevo()
            {
                Producto p = new Producto();
                return View(p);
            }

            [HttpPost]
            public ActionResult Nuevo(Producto p)
            {
                if (ModelState.IsValid)
                {
                    _db = new bdSupermercado();
                    _db.Productos.Add(p);
                    _db.SaveChanges();
                    return RedirectToAction("Index", "Producto");

                }
                return View(p);
            }
            public ActionResult Ver(int id)
            {
                Producto p = null;
                using (_db = new bdSupermercado())
                {
                    p = _db.Productos.Find(id);
                }
                return View(p);
            }

            public ActionResult Editar(int id)
            {
                Producto p = null;
                using (_db = new bdSupermercado())
                {
                    p = _db.Productos.Find(id);
                }
                return View(p);
            }

            [HttpPost]
            public ActionResult Editar(Producto p)
            {
                if (ModelState.IsValid)
                {
                    _db = new bdSupermercado();
                    _db.Entry(p).State = EntityState.Modified;
                    _db.SaveChanges();
                    return RedirectToAction("Ver", "Producto", new { id = p.Id });
                }
                return View(p);
            }
        }
    }
