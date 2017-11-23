using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCMaths
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name:"Addition",
                url: "Addition",
                defaults: new { controller = "Math1", action = "Add", id = UrlParameter.Optional}
            );

            routes.MapRoute(
                name: "Subtraction",
                url: "Subtraction",
                defaults: new { controller = "Math1", action = "Sub", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Division",
                url: "Division",
                defaults: new { controller = "Math2", action = "Divide", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Multiplication",
                url: "Multiplication",
                defaults: new { controller = "Math2", action = "Multiply", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Operations",
                url: "Operations",
                defaults: new { controller = "Math", action = "Operations", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Math", action = "Main", id = UrlParameter.Optional }
            );
        }
    }
}
