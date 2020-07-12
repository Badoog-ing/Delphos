using Delphos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Delphos.Controllers
{
    public class VentaController : Controller
    {
        // GET: Venta
        private bdSupermercado _db;
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VentaDelDia()
        {
            return View();
        }

        public ActionResult DetalleBoleta()
        {
            return View();
        }

    }
}