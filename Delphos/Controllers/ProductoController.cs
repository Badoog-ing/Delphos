using Delphos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace Delphos.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
            private bdSupermercado _db;
/*            public ActionResult Index()
            {
                IEnumerable<Producto> productos = null;
                _db = new bdSupermercado();
                productos = _db.Productos.ToList();
                return View(productos);
            }*/
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
                    using (_db = new bdSupermercado())
                    {
                        var Lista = from u in _db.Productos
                                    where u.Sku == p.Sku
                                    select u;
                    if (Lista.Count() > 0)
                    {
                        Request.Flash("danger", "El producto ya esta registrado");
                        /*return View("<script language='javascript' type='text/javascript'>alert('El Producto ya esta registrado');</script>");*/
                        /*return Content("Hola");*/
                    }
                    else
                    {
                        _db = new bdSupermercado();
                        p.FechaCreacion = DateTime.Today;
                        _db.Productos.Add(p);
                        _db.SaveChanges();
                        Request.Flash("success", "Producto agregado");
                        return RedirectToAction("Index", "Producto");
                    }
                    }
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
            //  (se reemplaza por el metodo de arriba de listar todos)
            //falta cambiar el valor a int y mostrar un mensaje cuando no encuentre producto
            public ActionResult Index(string searchString)
            {
                _db = new bdSupermercado();
                var productos = from b in _db.Productos
                                   select b;

                if (!String.IsNullOrEmpty(searchString))
                {
                    productos = productos.Where(b => b.Sku.ToString().Contains(searchString));
                }

                return View(productos);
            }
        }
    }
