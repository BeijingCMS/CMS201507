using SSOA.Web.Framework.Mvc;

namespace SSOA.Admin.Models.Home
{
    public partial class DashboardModel : BaseSSOAModel
    {
        public bool IsLoggedInAsVendor { get; set; }
    }
}