using SSOA.Web.Framework.Mvc;

namespace SSOA.Web.Models.Checkout
{
    public partial class OnePageCheckoutModel : BaseSSOAModel
    {
        public bool ShippingRequired { get; set; }
        public bool DisableBillingAddressCheckoutStep { get; set; }
    }
}