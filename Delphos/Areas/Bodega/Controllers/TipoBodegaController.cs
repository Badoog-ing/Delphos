using Delphos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Delphos.Areas.Bodega.Controllers
{
    public class TipoBodegaController : Controller
    {
        // GET: Bodega/TipoBodega
        private bdSupermercado _db;
        public ActionResult Origen()
        {
            IEnumerable<TablaBodega> bodegas = null;
            _db = new bdSupermercado();
            bodegas = _db.Bodegas.ToList();

            List<BodegaTipo> b = _db.BodegaTipos.ToList();
            ViewBag.b = b;


                var Lista = from u in _db.Bodegas
                            where u.TipoBodega == 1
                            select u;
                return View(Lista);

        }

        public ActionResult Destino()
        {
            IEnumerable<TablaBodega> bodegas = null;
            _db = new bdSupermercado();
            bodegas = _db.Bodegas.ToList();

            List<BodegaTipo> b = _db.BodegaTipos.ToList();
            ViewBag.b = b;


            var Lista = from u in _db.Bodegas
                        where u.TipoBodega == 2
                        select u;
            return View(Lista);

        }
    }
}