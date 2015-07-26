using SSOA.Web.Framework.Mvc;

namespace SSOA.Web.Models.Checkout
{
    public partial class CheckoutCompletedModel : BaseSSOAModel
    {
        public int OrderId { get; set; }
        public bool OnePageCheckoutEnabled { get; set; }
    }
}