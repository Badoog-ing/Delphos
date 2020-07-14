﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Delphos.Areas.Caja.Controllers
{
    public class CerrarSessionController : Controller
    {
        // GET: CerrarSession
        public ActionResult Cerrar()
        {
            Session["Usuario"] = null;
            return RedirectToAction("Index", "Welcome");
        }
    }
}