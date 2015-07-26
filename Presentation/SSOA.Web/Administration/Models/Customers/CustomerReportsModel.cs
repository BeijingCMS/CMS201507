using SSOA.Web.Framework.Mvc;

namespace SSOA.Admin.Models.Customers
{
    public partial class CustomerReportsModel : BaseSSOAModel
    {
        public BestCustomersReportModel BestCustomersByOrderTotal { get; set; }
        public BestCustomersReportModel BestCustomersByNumberOfOrders { get; set; }
    }
}