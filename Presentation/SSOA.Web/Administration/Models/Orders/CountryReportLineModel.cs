using SSOA.Web.Framework;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Admin.Models.Orders
{
    public partial class CountryReportLineModel : BaseSSOAModel
    {
        [SSOAResourceDisplayName("Admin.SalesReport.Country.Fields.CountryName")]
        public string CountryName { get; set; }

        [SSOAResourceDisplayName("Admin.SalesReport.Country.Fields.TotalOrders")]
        public int TotalOrders { get; set; }

        [SSOAResourceDisplayName("Admin.SalesReport.Country.Fields.SumOrders")]
        public string SumOrders { get; set; }
    }
}