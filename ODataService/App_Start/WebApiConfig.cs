using Microsoft.OData.Edm;
using ODataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.OData.Batch;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;

namespace ODataService
{
    public static class WebApiConfig
    {
        //public static void Register(HttpConfiguration config)
        //{
        //    // Web API configuration and services

        //    // Web API routes
        //    //config.MapHttpAttributeRoutes();

        //    //config.Routes.MapHttpRoute(
        //    //    name: "DefaultApi",
        //    //    routeTemplate: "api/{controller}/{id}",
        //    //    defaults: new { id = RouteParameter.Optional }
        //    //);
        //    var builder = new ODataConventionModelBuilder();
        //    builder.EntitySet<Student>("Students");
        //    config.MapODataServiceRoute("ODataRoute", null, builder.GetEdmModel());
        //}
        public static void Register(HttpConfiguration config)
        {
            config.MapODataServiceRoute("odata", null, GetEdmModel(), new DefaultODataBatchHandler(GlobalConfiguration.DefaultServer));
            config.Count().Filter().OrderBy().Expand().Select().MaxTop(null); //new line
            config.EnsureInitialized();
        }
        private static IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.Namespace = "Demos";
            builder.ContainerName = "DefaultContainer";
            builder.EntitySet<Student>("Students");
            builder.EntitySet<Book>("Books");
            var edmModel = builder.GetEdmModel();
            return edmModel;
        }
    }
}
