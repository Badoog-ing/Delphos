using Delphos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Delphos.Areas.Bodega.Controllers
{
    public class RecepcionController : Controller
    {
        private bdSupermercado _db;
        public ActionResult Index()
        {
            /*            IEnumerable<Recepcion> recepciones = null;    Aun no tiene nada que mostrar
                        _db = new bdSupermercado();
                        recepciones = _db.Recepciones.ToList();
                        return View(recepciones);*/
            return View();
        }
        public ActionResult Nuevo()
        {
            Recepcion r = new Recepcion();
            return View(r);
        }

        [HttpPost]
        public ActionResult Nuevo(Recepcion r)
        {
            if (ModelState.IsValid)
            {
                //Guardando en la bbdd
                _db = new bdSupermercado();
                _db.Recepciones.Add(r);
                _db.SaveChanges();
                return RedirectToAction("Index", "Recepcion");
            }
            return View(r);
        }
        public ActionResult Ver(int id)
        {
            Recepcion r = null;
            using (_db = new bdSupermercado())
            {
                r = _db.Recepciones.Find(id);
            }
            return View(r);
        }

        public ActionResult Editar(int id)
        {
            Recepcion r = null;
            using (_db = new bdSupermercado())
            {
                r = _db.Recepciones.Find(id);
            }
            return View(r);
        }

        [HttpPost]
        public ActionResult Editar(Recepcion r)
        {
            if (ModelState.IsValid)
            {
                _db = new bdSupermercado();
                _db.Entry(r).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Ver", "Recepcion", new { id = r.Id });
            }
            return View(r);
        }

    }
}