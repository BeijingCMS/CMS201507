using System.Web.Mvc;
using SSOA.Web.Framework.Security;

namespace SSOA.Web.Controllers
{
    public partial class HomeController : BasePublicController
    {
        [SSOAHttpsRequirement(SslRequirement.No)]
        public ActionResult Index()
        {
            return View();
        }
    }
}
