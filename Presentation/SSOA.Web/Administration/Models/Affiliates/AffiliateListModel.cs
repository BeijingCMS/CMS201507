using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using SSOA.Web.Framework;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Admin.Models.Affiliates
{
    public partial class AffiliateListModel : BaseSSOAModel
    {
        [SSOAResourceDisplayName("Admin.Affiliates.List.SearchFirstName")]
        [AllowHtml]
        public string SearchFirstName { get; set; }

        [SSOAResourceDisplayName("Admin.Affiliates.List.SearchLastName")]
        [AllowHtml]
        public string SearchLastName { get; set; }

        [SSOAResourceDisplayName("Admin.Affiliates.List.SearchFriendlyUrlName")]
        [AllowHtml]
        public string SearchFriendlyUrlName { get; set; }

        [SSOAResourceDisplayName("Admin.Affiliates.List.LoadOnlyWithOrders")]
        public bool LoadOnlyWithOrders { get; set; }
        [SSOAResourceDisplayName("Admin.Affiliates.List.OrdersCreatedFromUtc")]
        [UIHint("DateNullable")]
        public DateTime? OrdersCreatedFromUtc { get; set; }
        [SSOAResourceDisplayName("Admin.Affiliates.List.OrdersCreatedToUtc")]
        [UIHint("DateNullable")]
        public DateTime? OrdersCreatedToUtc { get; set; }
    }
}