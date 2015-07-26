using System.Web.Routing;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Web.Models.Cms
{
    public partial class RenderWidgetModel : BaseSSOAModel
    {
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public RouteValueDictionary RouteValues { get; set; }
    }
}