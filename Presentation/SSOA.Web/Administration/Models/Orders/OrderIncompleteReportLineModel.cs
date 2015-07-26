using SSOA.Web.Framework;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Admin.Models.Orders
{
    public partial class OrderIncompleteReportLineModel : BaseSSOAModel
    {
        [SSOAResourceDisplayName("Admin.SalesReport.Incomplete.Item")]
        public string Item { get; set; }

        [SSOAResourceDisplayName("Admin.SalesReport.Incomplete.Total")]
        public string Total { get; set; }

        [SSOAResourceDisplayName("Admin.SalesReport.Incomplete.Count")]
        public int Count { get; set; }

        [SSOAResourceDisplayName("Admin.SalesReport.Incomplete.View")]
        public string ViewLink { get; set; }
    }
}
