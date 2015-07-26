using System;
using System.Web.Mvc;
using SSOA.Admin.Models.Common;
using SSOA.Web.Framework;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Admin.Models.Affiliates
{
    public partial class AffiliateModel : BaseSSOAEntityModel
    {
        public AffiliateModel()
        {
            Address = new AddressModel();
        }

        [SSOAResourceDisplayName("Admin.Affiliates.Fields.ID")]
        public override int Id { get; set; }

        [SSOAResourceDisplayName("Admin.Affiliates.Fields.URL")]
        public string Url { get; set; }


        [SSOAResourceDisplayName("Admin.Affiliates.Fields.AdminComment")]
        [AllowHtml]
        public string AdminComment { get; set; }

        [SSOAResourceDisplayName("Admin.Affiliates.Fields.FriendlyUrlName")]
        [AllowHtml]
        public string FriendlyUrlName { get; set; }
        
        [SSOAResourceDisplayName("Admin.Affiliates.Fields.Active")]
        public bool Active { get; set; }

        public AddressModel Address { get; set; }

        #region Nested classes
        
        public partial class AffiliatedOrderModel : BaseSSOAEntityModel
        {
            [SSOAResourceDisplayName("Admin.Affiliates.Orders.Order")]
            public override int Id { get; set; }

            [SSOAResourceDisplayName("Admin.Affiliates.Orders.OrderStatus")]
            public string OrderStatus { get; set; }

            [SSOAResourceDisplayName("Admin.Affiliates.Orders.PaymentStatus")]
            public string PaymentStatus { get; set; }

            [SSOAResourceDisplayName("Admin.Affiliates.Orders.ShippingStatus")]
            public string ShippingStatus { get; set; }

            [SSOAResourceDisplayName("Admin.Affiliates.Orders.OrderTotal")]
            public string OrderTotal { get; set; }

            [SSOAResourceDisplayName("Admin.Affiliates.Orders.CreatedOn")]
            public DateTime CreatedOn { get; set; }
        }

        public partial class AffiliatedCustomerModel : BaseSSOAEntityModel
        {
            [SSOAResourceDisplayName("Admin.Affiliates.Customers.Name")]
            public string Name { get; set; }
        }

        #endregion
    }
}