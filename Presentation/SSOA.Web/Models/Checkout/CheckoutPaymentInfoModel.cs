using System.Web.Routing;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Web.Models.Checkout
{
    public partial class CheckoutPaymentInfoModel : BaseSSOAModel
    {
        public string PaymentInfoActionName { get; set; }
        public string PaymentInfoControllerName { get; set; }
        public RouteValueDictionary PaymentInfoRouteValues { get; set; }

        /// <summary>
        /// Used on one-page checkout page
        /// </summary>
        public bool DisplayOrderTotals { get; set; }
    }
}