﻿using Delphos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Delphos.Areas.Bodega.Controllers
{
    public class TraspasoController : Controller
    {
        bdSupermercado _db = new bdSupermercado();

        // GET: Traspaso
        public ActionResult Index()
        {
            bdSupermercado _db = new bdSupermercado();
            
            List<BodegaTipo> Bodegas = _db.BodegaTipos.ToList();
            ViewBag.Bodegas = Bodegas;

            return View(_db.Traspasos.ToList());
        }

        public ActionResult TraspasoDetalle(int id)
        {
            Traspaso t = _db.Traspasos.Find(id);
            if (t == null)
            {
                return new HttpNotFoundResult();
            }
            List<TraspasoDetalle> detalles = _db.TraspasoDetalles.ToList();
            ViewBag.detalles = detalles;

            List<Producto> productos = _db.Productos.ToList();
            ViewBag.productos = productos;
            return View(t);
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
            return Content("El producto no se encuentra");                    
                }
        }
        return View(productos);
        }


    }
}