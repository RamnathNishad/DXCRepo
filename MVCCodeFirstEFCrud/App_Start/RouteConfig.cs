using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCCodeFirstEFCrud
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Customer", action = "Index", id = UrlParameter.Optional },
                constraints: new { id = "[0-9]*" }
            );

            routes.MapRoute(
                name: "r2",
                url: "HRMS/{controller}/{action}/{id}/{name}",
                defaults: new { controller = "Customer", action = "Index", id = UrlParameter.Optional, name = UrlParameter.Optional },
                constraints: new
                {
                    id = "[0-9]*",
                    name = "[aA-zZ]*"
                }
            );
        }
    }
}
