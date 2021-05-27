using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //new way of declaring costum routes

            routes.MapMvcAttributeRoutes();
            //The order of the routes matter, list them from the most specific to the most generic
            //this is the old way to create costume routes
           // routes.MapRoute(
               // "MoviesByReleaseDate",// This name should be unique
               // "movies/released/{year}/{month}",//parameters are enclosed in curly braces 
               // new { controller= "Movies", action = "ByReleaseDate"},//anonymus object and efine controllers and actions 
               // new { year = @"\d{4}", month = @"\d{2}"}//regular expressions are use to apply constraints, the number in curlies represent the repetitions  => meaning the how many characters are expecter in the url. Optionally in your costume route your could give it set parameters such as  year="{2015 | 2016}", this will only accpet either of these two parameters
               // );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
