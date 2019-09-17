using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EjercicioPractico
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();
            routes.MapRoute(
                "NewCoche",
                "Coche/NewCoche", //Se agrega un nuevo URL
                new { controller = "Coche", action = "NewCoche" }//Se dice a que funcion de que controlador se agregar ese URL 
            );

            routes.MapRoute(
               "User",
               "User/User",
               new { controller = "User", action = "User" }
            );

            routes.MapRoute(
               "NewUser",
               "User/NewUser",
               new { controller = "User", action = "NewUser" }
            );

            routes.MapRoute(
               "Alquiler",
               "Alquiler/Alquiler", 
               new { controller = "Alquiler", action = "Alquiler" }
            );

            routes.MapRoute(
               "ListAlquiler",
               "Alquiler/ListaAlquiler",
               new { controller = "Alquiler", action = "ListAlquiler" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Coche", action = "Coche", id = UrlParameter.Optional }
            );
        }
    }
}
