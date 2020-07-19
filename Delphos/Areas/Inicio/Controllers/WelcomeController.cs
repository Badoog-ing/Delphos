using Delphos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Delphos.Areas.Inicio.Controllers
{
    public class WelcomeController : Controller
    {
        private bdSupermercado _db;

        // GET: Welcome
        public ActionResult Index()
        {
            return View();
        }

        //Temporal mientras se crea la autentificacion
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Entrar(string user, string pass)
        {
            try
            {
                using (_db = new bdSupermercado())
                {
                    var Lista = from u in _db.Usuarios
                                where u.Nombre == user && u.Password == pass
                                select u;

                    if (Lista.Count() > 0)
                    {
                        Usuario oUser = Lista.First();
                        Session["Usuario"] = oUser;
                    }
                    else
                    {
                        return Content("No se encuentra el user");
                    }
                }

                return Content("Hola");
            }
            catch (Exception ex)
            {

                return Content("Ocurrio un error" + ex.Message);
            }
        }
        public ActionResult Sugerencia()
        {
            return View();
        }
    }
}