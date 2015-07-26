using System;
using System.Configuration;
using System.Web.Mvc;
using System.Web.Routing;
using SSOA.Web.Framework.Localization;
using SSOA.Web.Framework.Mvc.Routes;

namespace SSOA.Web.Infrastructure
{
    //Routes used for backward compatibility with 2.x versions of SSOACommerce
    public partial class BackwardCompatibility2XRouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            var supportPreviousSSOAcommerceVersions =
                !String.IsNullOrEmpty(ConfigurationManager.AppSettings["SupportPreviousSSOAcommerceVersions"]) &&
                Convert.ToBoolean(ConfigurationManager.AppSettings["SupportPreviousSSOAcommerceVersions"]);
            if (!supportPreviousSSOAcommerceVersions)
                return;

            //products
            routes.MapLocalizedRoute("", "p/{productId}/{SeName}",
                new { controller = "BackwardCompatibility2X", action = "RedirectProductById", SeName = UrlParameter.Optional },
                new { productId = @"\d+" },
                new[] { "SSOA.Web.Controllers" });

            //categories
            routes.MapLocalizedRoute("", "c/{categoryId}/{SeName}",
                new { controller = "BackwardCompatibility2X", action = "RedirectCategoryById", SeName = UrlParameter.Optional },
                new { categoryId = @"\d+" },
                new[] { "SSOA.Web.Controllers" });

            //manufacturers
            routes.MapLocalizedRoute("", "m/{manufacturerId}/{SeName}",
                new { controller = "BackwardCompatibility2X", action = "RedirectManufacturerById", SeName = UrlParameter.Optional },
                new { manufacturerId = @"\d+" },
                new[] { "SSOA.Web.Controllers" });

            //news
            routes.MapLocalizedRoute("", "news/{newsItemId}/{SeName}",
                new { controller = "BackwardCompatibility2X", action = "RedirectNewsItemById", SeName = UrlParameter.Optional },
                new { newsItemId = @"\d+" },
                new[] { "SSOA.Web.Controllers" });

            //blog
            routes.MapLocalizedRoute("", "blog/{blogPostId}/{SeName}",
                new { controller = "BackwardCompatibility2X", action = "RedirectBlogPostById", SeName = UrlParameter.Optional },
                new { blogPostId = @"\d+" },
                new[] { "SSOA.Web.Controllers" });

            //topic
            routes.MapLocalizedRoute("", "t/{SystemName}",
                new { controller = "BackwardCompatibility2X", action = "RedirectTopicBySystemName" },
                new[] { "SSOA.Web.Controllers" });

            //vendors
            routes.MapLocalizedRoute("", "vendor/{vendorId}/{SeName}",
                new { controller = "BackwardCompatibility2X", action = "RedirectVendorById", SeName = UrlParameter.Optional },
                new { vendorId = @"\d+" },
                new[] { "SSOA.Web.Controllers" });
        }

        public int Priority
        {
            get
            {
                //register it after all other IRouteProvider are processed
                return -1000;
            }
        }
    }
}
