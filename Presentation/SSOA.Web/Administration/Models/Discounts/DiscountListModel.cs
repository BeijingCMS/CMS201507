using System.Collections.Generic;
using System.Web.Mvc;
using SSOA.Web.Framework;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Admin.Models.Discounts
{
    public partial class DiscountListModel : BaseSSOAModel
    {
        public DiscountListModel()
        {
            AvailableDiscountTypes = new List<SelectListItem>();
        }

        [SSOAResourceDisplayName("Admin.Promotions.Discounts.List.SearchDiscountCouponCode")]
        [AllowHtml]
        public string SearchDiscountCouponCode { get; set; }

        [SSOAResourceDisplayName("Admin.Promotions.Discounts.List.SearchDiscountName")]
        [AllowHtml]
        public string SearchDiscountName { get; set; }

        [SSOAResourceDisplayName("Admin.Promotions.Discounts.List.SearchDiscountType")]
        public int SearchDiscountTypeId { get; set; }
        public IList<SelectListItem> AvailableDiscountTypes { get; set; }
    }
}