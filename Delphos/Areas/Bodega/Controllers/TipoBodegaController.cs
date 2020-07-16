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
        public ActionResult Index()
        {
            IEnumerable<TablaBodega> bodegas = null;
            _db = new bdSupermercado();
            bodegas = _db.Bodegas.ToList();
            return View(bodegas);
        }
    }
}