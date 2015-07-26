using System;
using System.Configuration;
using System.Web.Mvc;
using System.Web.Routing;
using SSOA.Web.Framework.Mvc.Routes;

namespace SSOA.Web.Infrastructure
{
    //Routes used for backward compatibility with 1.x versions of SSOACommerce
    public partial class BackwardCompatibility1XRouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            var supportPreviousSSOAcommerceVersions =
                !String.IsNullOrEmpty(ConfigurationManager.AppSettings["SupportPreviousSSOAcommerceVersions"]) &&
                Convert.ToBoolean(ConfigurationManager.AppSettings["SupportPreviousSSOAcommerceVersions"]);
            if (!supportPreviousSSOAcommerceVersions)
                return;

            //all old aspx URLs
            routes.MapRoute("", "{oldfilename}.aspx",
                            new { controller = "BackwardCompatibility1X", action = "GeneralRedirect" },
                            new[] { "SSOA.Web.Controllers" });
            
            //products
            routes.MapRoute("", "products/{id}.aspx",
                            new { controller = "BackwardCompatibility1X", action = "RedirectProduct"},
                            new[] { "SSOA.Web.Controllers" });
            
            //categories
            routes.MapRoute("", "category/{id}.aspx",
                            new { controller = "BackwardCompatibility1X", action = "RedirectCategory" },
                            new[] { "SSOA.Web.Controllers" });

            //manufacturers
            routes.MapRoute("", "manufacturer/{id}.aspx",
                            new { controller = "BackwardCompatibility1X", action = "RedirectManufacturer" },
                            new[] { "SSOA.Web.Controllers" });

            //product tags
            routes.MapRoute("", "producttag/{id}.aspx",
                            new { controller = "BackwardCompatibility1X", action = "RedirectProductTag" },
                            new[] { "SSOA.Web.Controllers" });

            //news
            routes.MapRoute("", "news/{id}.aspx",
                            new { controller = "BackwardCompatibility1X", action = "RedirectNewsItem" },
                            new[] { "SSOA.Web.Controllers" });

            //blog posts
            routes.MapRoute("", "blog/{id}.aspx",
                            new { controller = "BackwardCompatibility1X", action = "RedirectBlogPost" },
                            new[] { "SSOA.Web.Controllers" });

            //topics
            routes.MapRoute("", "topic/{id}.aspx",
                            new { controller = "BackwardCompatibility1X", action = "RedirectTopic" },
                            new[] { "SSOA.Web.Controllers" });

            //forums
            routes.MapRoute("", "boards/fg/{id}.aspx",
                            new { controller = "BackwardCompatibility1X", action = "RedirectForumGroup" },
                            new[] { "SSOA.Web.Controllers" });
            routes.MapRoute("", "boards/f/{id}.aspx",
                            new { controller = "BackwardCompatibility1X", action = "RedirectForum" },
                            new[] { "SSOA.Web.Controllers" });
            routes.MapRoute("", "boards/t/{id}.aspx",
                            new { controller = "BackwardCompatibility1X", action = "RedirectForumTopic" },
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
