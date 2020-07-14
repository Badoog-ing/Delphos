using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Delphos.Models;

namespace Delphos.Areas.Administrador.Controllers
{
    public class UsuarioController : Controller
    {
        private bdSupermercado _db;
        public ActionResult Index()
        {
            IEnumerable<Usuario> usuarios = null;
            _db = new bdSupermercado();
            usuarios = _db.Usuarios.ToList();
            return View(usuarios);
        }
        public ActionResult Nuevo()
        {
            Usuario u = new Usuario();
            return View(u);
        }

        [HttpPost]
        public ActionResult Nuevo(Usuario u)
        {
            if (ModelState.IsValid)
            {
                _db = new bdSupermercado();
                _db.Usuarios.Add(u);
                _db.SaveChanges();
                Request.Flash("success", "Usuario agregado con exito !!!");
                return RedirectToAction("Index", "Usuario");
            }
            return View(u);
        }
        public ActionResult Ver(int id)
        {
            Usuario u = null;
            using (_db = new bdSupermercado())
            {
                u = _db.Usuarios.Find(id);
            }
            return View(u);
        }

        public ActionResult Editar(int id)
        {
            Usuario u = null;
            using (_db = new bdSupermercado())
            {
                u = _db.Usuarios.Find(id);
            }
            return View(u);
        }

        [HttpPost]
        public ActionResult Editar(Usuario u)
        {
            if (ModelState.IsValid)
            {
                _db = new bdSupermercado();
                _db.Entry(u).State = EntityState.Modified;
                _db.SaveChanges();
                Request.Flash("success", "Usuario Actualizado");
                return RedirectToAction("Ver", "Usuario", new { id = u.Id });
            }
            return View(u);
        }

    }
}
