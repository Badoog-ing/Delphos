using Delphos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Delphos.Controllers
{
    public class CargoController : Controller
    {
        // GET: Cargo
        private bdSupermercado _db;
        public ActionResult Index()
        {
            IEnumerable<Cargo> cargos = null;
            _db = new bdSupermercado();
            cargos = _db.Cargos.ToList();
            return View(cargos);
        }
    }
}