using System.Web.Routing;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Admin.Models.Plugins
{
    public partial class MiscPluginModel : BaseSSOAModel
    {
        public string FriendlyName { get; set; }

        public string ConfigurationActionName { get; set; }
        public string ConfigurationControllerName { get; set; }
        public RouteValueDictionary ConfigurationRouteValues { get; set; }
    }
}