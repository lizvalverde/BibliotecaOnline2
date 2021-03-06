using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebBibliotecaOnline2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           routes.MapRoute(
           name: "nombre",
           url: "Pruebas/ObjetoMultiple/",
           defaults: new { controller = "Pruebas", action = "ObjetoMultiple" }
          );
            //-----ruta para miaplicacion/controlador/accion/id/nombre  
            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );
           
            //routes.MapRoute(
            //    name: "nombre",
            //    url: "Pruebas/DameFecha2/{mes}/{ano}",
            //    defaults: new { controller = "Pruebas", action = "DameFecha2" }
            //);

        }
    }
}
