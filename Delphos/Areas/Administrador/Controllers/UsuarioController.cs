using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
using Delphos.Models;
using Microsoft.Ajax.Utilities;

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
                List<Cargo> cargos = _db.Cargos.ToList();
                ViewBag.cargos = cargos;

                using (_db = new bdSupermercado())
                {
                    var Lista = from p in _db.Proveedores
                                where p.Rut == u.Rut
                                select p;

                    if (Lista.Count() > 0)
                    {
                        Request.Flash("danger", "El Rut ya esta registrado");
                        /*return View("<script language='javascript' type='text/javascript'>alert('El Producto ya esta registrado');</script>");*/
                        /*return Content("Hola");*/
                    }
                    else
                    {
                        _db = new bdSupermercado();
                        _db.Usuarios.Add(u);
                        u.FechasCreacion = DateTime.Today;
                        _db.SaveChanges();
                        Request.Flash("success", "Registrado con exito !!!");
                        return RedirectToAction("Index", "Usuario");
                    }
                }

            }

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
        public ActionResult Editar(int id, Usuario u)
        {
            Usuario usuario = _db.Usuarios.Find(id);
            if (u == null)
            {
                return new HttpNotFoundResult();
            }
            if (ModelState.IsValid)
            {
                _db = new bdSupermercado();
                _db.Entry(usuario).State = EntityState.Detached;
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
