using SSOA.Web.Framework.Mvc;

namespace SSOA.Web.Models.Checkout
{
    public partial class CheckoutProgressModel : BaseSSOAModel
    {
        public CheckoutProgressStep CheckoutProgressStep { get; set; }
    }

    public enum CheckoutProgressStep
    {
        Cart,
        Address,
        Shipping,
        Payment,
        Confirm,
        Complete
    }
}