using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;


namespace WebApplication2
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //string origins = GetAllowedOrigins();
            //var cors = new EnableCorsAttribute(origins, "*", "*");
            //config.EnableCors(cors);


            // Web API routes
            config.MapHttpAttributeRoutes();


            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new {id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
            name: "TestCV",
            routeTemplate: "test/CV/{id}",
            defaults: new { controller = "CVTest", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
            name: "TestDB",
            routeTemplate: "test/DB/{id}",
            defaults: new { controller = "DBTest", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
            name: "TestNHC",
            routeTemplate: "test/NHC/{id}",
            defaults: new { controller = "NHCTest", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
            name: "TestRPI",
            routeTemplate: "test/RPI/{id}",
            defaults: new { controller = "RPITest", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
            name: "TestEXT",
            routeTemplate: "test/EXT/{id}",
            defaults: new { controller = "EXTTest", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
            name: "TestLOG",
            routeTemplate: "test/LOG/{id}",
            defaults: new { controller = "LOGTest", id = RouteParameter.Optional }
            );


            //Format respsonse as JSON
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/plain"));

        }

        //private static string GetAllowedOrigins()
        //{
        //    //Make a call to the database to get allowed origins and convert to a comma separated string
        //    return "http://www.example.com,http://localhost:59452,http://localhost:25495";
        //}

    }
}
