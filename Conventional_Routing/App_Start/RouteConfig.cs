using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Conventional_Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name:"AllStudent",
                url:"Student",
                defaults: new { Controller = "Student", Action="GetAllStudent" }
                );

            routes.MapRoute(
                name: "Student",
                url: "Student/{id}",
                defaults: new { Controller = "Student", Action = "GetStudent" }
                );

            routes.MapRoute(
                name: "Address",
                url: "Student/{id}/Address",
                defaults: new { Controller = "Student", Action = "GetStudentAddress" },
                constraints: new { id= @"\d+"}
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
