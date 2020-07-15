using Delphos.Areas.Inicio.Controllers;
using Delphos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Delphos.Filtros
{
    public class VerificarUsuario : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var oUser = (Usuario)HttpContext.Current.Session["Usuario"];

            if (oUser == null)
            {

                if (filterContext.Controller is WelcomeController == false)
                {

                    filterContext.HttpContext.Response.Redirect("~/Welcome/Login");
                }

            }
            else
            {
                if (filterContext.Controller is WelcomeController == true)
                {
                    if (oUser.CargoId == 1)
                    {
                        filterContext.HttpContext.Response.Redirect("~/Administrador/Usuario/Index");
                    }
                    if (oUser.CargoId == 2)
                    {
                        filterContext.HttpContext.Response.Redirect("~/Bodega/Recepcion/Index");
                    }
                    if (oUser.CargoId == 3)
                    {
                        filterContext.HttpContext.Response.Redirect("~/Venta/Index");
                    }
                    if (oUser.CargoId == 4)
                    {
                        filterContext.HttpContext.Response.Redirect("~/Comercial/Producto/Index");
                    }
                }
            }

            base.OnActionExecuted(filterContext);
        }
    }
}