using SSOA.Web.Framework;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Admin.Models.ShoppingCart
{
    public partial class ShoppingCartModel : BaseSSOAModel
    {
        [SSOAResourceDisplayName("Admin.CurrentCarts.Customer")]
        public int CustomerId { get; set; }
        [SSOAResourceDisplayName("Admin.CurrentCarts.Customer")]
        public string CustomerEmail { get; set; }

        [SSOAResourceDisplayName("Admin.CurrentCarts.TotalItems")]
        public int TotalItems { get; set; }
    }
}