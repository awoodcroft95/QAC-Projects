using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCPeople
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Addition",
                url: "add/{a}/{b}",
                defaults: new { controller = "Math", action = "Add", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Subtraction",
                url: "sub/{a}/{b}",
                defaults: new { controller = "Math", action = "Subtract", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Multiplication",
                url: "mult/{a}/{b}",
                defaults: new { controller = "Math", action = "Multiply", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Division",
                url: "div/{a}/{b}",
                defaults: new { controller = "Math", action = "Divide", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
