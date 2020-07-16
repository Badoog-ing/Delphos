using Delphos.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Delphos.Areas.Bodega.Controllers
{
    public class BodegaController : Controller
    {
        // GET: Bodega/Bodega
        private bdSupermercado _db;
        public ActionResult Index()
        {
            IEnumerable<Bodega> productos = null;
            _db = new bdSupermercado();
            productos = _db.Productos.ToList();
            return View(productos);
        }
    }
}