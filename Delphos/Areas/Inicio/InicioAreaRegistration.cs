using System.Web.Mvc;

namespace Delphos.Areas.Inicio
{
    public class InicioAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Inicio";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Inicio_default",
                "Inicio/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Delphos.Areas.Inicio.Controllers" }
            );
        }
    }
}