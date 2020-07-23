using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Delphos.Models;

namespace Delphos.Areas.Administrador.Controllers
{
    public class UsuarioController : Controller
    {
        bdSupermercado _db = new bdSupermercado();
        public ActionResult Index()
        {
            bdSupermercado _db = new bdSupermercado();
            return View(_db.Usuarios.ToList());

        }
        public ActionResult Nuevo()
        {
            Usuario u = new Usuario();
            List<Cargo> cargos = _db.Cargos.ToList();
            ViewBag.cargos = cargos;
            return View(u);
        }

        [HttpPost]
        public ActionResult Nuevo(Usuario u)
        {
            if (ModelState.IsValid)
            {
                _db = new bdSupermercado();
                _db.Usuarios.Add(u);
                u.FechasCreacion = DateTime.Today;
                _db.SaveChanges();
                Request.Flash("success", "Registrado con exito !!!");
                return RedirectToAction("Index", "Usuario");
            }
            List<Cargo> cargos = _db.Cargos.ToList();
            ViewBag.cargos = cargos;
            return View(u);
        }

        public ActionResult Ver(int id)
        {
            Usuario u = _db.Usuarios.Find(id);
            if (u == null)
            {
                return new HttpNotFoundResult();
            }
            List<Cargo> cargos = _db.Cargos.ToList();
            ViewBag.cargos = cargos;
            return View(u);
        }

        public ActionResult Editar(int id)
        {
            Usuario u = _db.Usuarios.Find(id);
            if (u == null)
            {
                return new HttpNotFoundResult();
            }
            List<Cargo> cargos = _db.Cargos.ToList();
            ViewBag.cargos = cargos;
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
                Request.Flash("success", "Datos Actualizados");
                return RedirectToAction("Ver", "Usuario", new { id = u.Id });
            }
            List<Cargo> cargos = _db.Cargos.ToList();
            ViewBag.cargos = cargos;
            return View(u);
        }

    }
}
