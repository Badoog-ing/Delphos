﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Delphos.Areas.Comercial.Controllers
{
    public class OrdenDeCompraController : Controller
    {
        // GET: OrdenDeCompra
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Nuevo()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Ver(int id)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Editar(int id)
        {
            return View();
        }
        public ActionResult AgregarProducto()
        {
            return View();
        }
    }
}