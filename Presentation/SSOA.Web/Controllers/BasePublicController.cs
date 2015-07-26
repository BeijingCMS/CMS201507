using System.Web.Mvc;
using System.Web.Routing;
using SSOA.Core.Infrastructure;
using SSOA.Web.Framework;
using SSOA.Web.Framework.Controllers;
using SSOA.Web.Framework.Security;
using SSOA.Web.Framework.Seo;

namespace SSOA.Web.Controllers
{
    [CheckAffiliate]
    [PublicStoreAllowNavigation]
    [LanguageSeoCode]
    [SSOAHttpsRequirement(SslRequirement.NoMatter)]
    [WwwRequirement]
    public abstract partial class BasePublicController : BaseController
    {
        protected virtual ActionResult InvokeHttp404()
        {
            // Call target Controller and pass the routeData.
            IController errorController = EngineContext.Current.Resolve<CommonController>();

            var routeData = new RouteData();
            routeData.Values.Add("controller", "Common");
            routeData.Values.Add("action", "PageNotFound");

            errorController.Execute(new RequestContext(this.HttpContext, routeData));

            return new EmptyResult();
        }

    }
}
