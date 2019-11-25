using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;

namespace IdemMedina
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
           // config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

        }

        public class CustomJsonFormatter : JsonMediaTypeFormatter
        {
            public CustomJsonFormatter() { this.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html")); }

            public override void SetDefaultContentHeaders(Type type, HttpContentHeaders headers, MediaTypeHeaderValue mediaType) { base.SetDefaultContentHeaders(type, headers, mediaType); headers.ContentType = new MediaTypeHeaderValue("application/json"); }



        }

        //var json = config.Formatters.JsonFormatter;
        //json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
        //config.Formatters.Remove(config.Formatters.XmlFormatter);

        //((DefaultContractResolver)config.Formatters.JsonFormatter.SerializerSettings.ContractResolver).IgnoreSerializableAttribute = true;
    }
    }

