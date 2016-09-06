using System;
using System.Collections.Generic;
using System.Linq;
using StorageBenchmarkManager.Models;
using System.Web.Http;
using System.Web.Http.OData.Builder;

namespace StorageBenchmarkManager
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //// Web API configuration and services

            //// Web API routes
            //config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Product>("Products");
            config.Routes.MapODataRoute("odata", "odata", builder.GetEdmModel());
        }
    }
}
