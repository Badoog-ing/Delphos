using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Delphos.Areas.Bodega.Controllers
{
    public class TraspasoController : Controller
    {
        // GET: Traspaso
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detalles()
        {
            return View();
        }
        public ActionResult Crear()
        {
            return View();
        }
        //AUn no estoy seguro si necesita cun controlador independiente
        public ActionResult ListarProductos()
        {
            return View();
        }
    }
}