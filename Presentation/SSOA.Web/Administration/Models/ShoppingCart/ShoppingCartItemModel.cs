using System;
using SSOA.Web.Framework;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Admin.Models.ShoppingCart
{
    public partial class ShoppingCartItemModel : BaseSSOAEntityModel
    {
        [SSOAResourceDisplayName("Admin.CurrentCarts.Store")]
        public string Store { get; set; }
        [SSOAResourceDisplayName("Admin.CurrentCarts.Product")]
        public int ProductId { get; set; }
        [SSOAResourceDisplayName("Admin.CurrentCarts.Product")]
        public string ProductName { get; set; }
        public string AttributeInfo { get; set; }

        [SSOAResourceDisplayName("Admin.CurrentCarts.UnitPrice")]
        public string UnitPrice { get; set; }
        [SSOAResourceDisplayName("Admin.CurrentCarts.Quantity")]
        public int Quantity { get; set; }
        [SSOAResourceDisplayName("Admin.CurrentCarts.Total")]
        public string Total { get; set; }
        [SSOAResourceDisplayName("Admin.CurrentCarts.UpdatedOn")]
        public DateTime UpdatedOn { get; set; }
    }
}