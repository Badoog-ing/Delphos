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
        bdSupermercado _db = new bdSupermercado();
        public ActionResult Index()
        {
            return View();
        }


    }
}