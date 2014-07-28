using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using System.Net.Http.Headers;

namespace ManCave.Web
{
    public static class WebApiConfig
    {

        
        public static void Register(HttpConfiguration config)
        {

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/plain"));
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();
            
            config.Routes.MapHttpRoute(
             name: "Teamsapi",  
             routeTemplate: "api/v1/Teams/{id}",
             defaults: new { id = RouteParameter.Optional, controller = "apiTeams" } 
             );

            config.Routes.MapHttpRoute(
             name: "Carsapi",
             routeTemplate: "api/v1/Cars/{id}",
             defaults: new { id = RouteParameter.Optional, controller = "apiCars" }
             );

            config.Routes.MapHttpRoute(
             name: "Foodsapi",
             routeTemplate: "api/v1/Foods/{id}",
             defaults: new { id = RouteParameter.Optional, controller = "apiFoods" }
             );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
