using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCPCLSystem
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "DeleteRecord",
                url: "delete/{id}",
                defaults: new { controller = "Home", action = "DeleteRecord", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "InsertRecord",
                url: "InsertRecord",
                defaults: new { controller = "Home", action = "InsertRecord", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "EditRecord",
                url: "EditRecord",
                defaults: new { controller = "Home", action = "EditRecord", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "AddNewPayment",
                url: "AddPayment/{id}",
                defaults: new { controller = "Home", action = "AddNewPayment", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "InsertNewPayment",
                url: "InsertPayment",
                defaults: new { controller = "Home", action = "InsertNewPayment", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Payment Details",
                url: "payments/{id}",
                defaults: new { controller = "Home", action = "PaymentDetails", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "EditRecordForm",
                url: "edit/{id}",
                defaults: new { controller = "Home", action = "EditRecordForm", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "AddNewrecord",
                url: "NewRecord",
                defaults: new { controller = "Home", action = "AddNewRecord", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
