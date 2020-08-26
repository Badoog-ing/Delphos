using Delphos.Models;
using Delphos.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

            ViewBag.detalles = from tr in _db.Traspasos
                        where tr.Id == id
                        select tr;

            List<Producto> productos = _db.Productos.ToList();
            ViewBag.productos = productos;

            return View(t);
        }

        public ActionResult Nuevo()
        {
            Traspaso t = new Traspaso();

            List<BodegaTipo> tipobodega = _db.BodegaTipos.ToList();
            ViewBag.tipobodega = tipobodega;

            List<Producto> productos = _db.Productos.ToList();
            ViewBag.productos = productos;
            return View(t);
        }

        [HttpPost]
        public ActionResult Nuevo(Traspaso t)
        {
            if (ModelState.IsValid)
            {
                _db = new bdSupermercado();
                _db.Traspasos.Add(t);
                if(t.BodegaOrigen == 1)
                {
                    t.BodegaDestino = 2;
                }
                else
                {
                    t.BodegaDestino = 1;
                }
                t.FechaTraspaso = DateTime.Today;
                _db.SaveChanges();
                Request.Flash("success", "Registrado con exito !!!");
                return RedirectToAction("Index", "Traspaso");
            }
            List<BodegaTipo> tipobodega = _db.BodegaTipos.ToList();
            ViewBag.tipobodega = tipobodega;

            List<Producto> productos = _db.Productos.ToList();
            ViewBag.productos = productos;

            return View(t);
        }


    }
}