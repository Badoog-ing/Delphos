using Delphos.Areas.Administrador.Controllers;
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

                    filterContext.HttpContext.Response.Redirect("~/Inicio/Welcome/Login");
                }

            }
            else
            {
                if (filterContext.Controller is WelcomeController == true)
                {

                    switch (oUser.CargoId)
                    {
                        case 1:
                            filterContext.HttpContext.Response.Redirect("~/Administrador/Usuario/Index");
                            break;
                        case 2:
                            filterContext.HttpContext.Response.Redirect("~/Bodega/Recepcion/Index");
                            break;
                        case 3:
                            filterContext.HttpContext.Response.Redirect("~/Caja/Venta/Index");
                            break;
                        case 4:
                            filterContext.HttpContext.Response.Redirect("~/Comercial/Producto/Index");
                            break;
                        default:
                            filterContext.HttpContext.Response.Redirect("~/Inicio/Welcome/Login");
                            break;
                    }
                }
            }

            base.OnActionExecuted(filterContext);
        }
    }
}