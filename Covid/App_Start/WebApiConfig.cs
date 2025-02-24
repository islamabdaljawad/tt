﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Covid.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
           // EnableCorsAttribute cors = new EnableCorsAttribute("*","*","*");
            
           // config.EnableCors(cors);
            //config.EnableCors();
            //config.Filters.Add(new RequireHttpsAttribute());

           
        }
    }
}