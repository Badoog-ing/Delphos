using Delphos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;

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
                        /*return Content("TRABAJADOR NO REGISTRADO");*/
/*                        Request.Flash("danger", "Trabajador no Registrado");
                        ViewBag.Message = "Trabajador no Registrado";*/
                        return RedirectToAction("Index", "Welcome");
                    }
                }

                return Content("");
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

        [HttpPost]
        public ActionResult Sugerencia(Gmail model)
        {
            model.To = "delphosproyecto@gmail.com";
            MailMessage mm = new MailMessage("delphosproyecto@gmail.com", model.To);
            mm.Subject = model.Subject;
            mm.Body = model.Body;
            mm.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            NetworkCredential nc = new NetworkCredential("delphosproyecto@gmail.com", "delphos2020");
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = nc;
            smtp.Send(mm);
            ViewBag.Message = "Correo enviado con exito !!!";

            /*return Content("<script language='javascript' type='text/javascript'>alert('Thanks for Feedback!');</script>");*/
            return View();
        }
    }
}