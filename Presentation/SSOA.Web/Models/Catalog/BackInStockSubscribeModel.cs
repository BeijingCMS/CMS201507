﻿using SSOA.Web.Framework.Mvc;

namespace SSOA.Web.Models.Catalog
{
    public partial class BackInStockSubscribeModel : BaseSSOAModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSeName { get; set; }

        public bool IsCurrentCustomerRegistered { get; set; }
        public bool SubscriptionAllowed { get; set; }
        public bool AlreadySubscribed { get; set; }

        public int MaximumBackInStockSubscriptions { get; set; }
        public int CurrentNumberOfBackInStockSubscriptions { get; set; }
    }
}