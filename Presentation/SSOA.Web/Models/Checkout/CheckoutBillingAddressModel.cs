using System.Collections.Generic;
using SSOA.Web.Framework.Mvc;
using SSOA.Web.Models.Common;

namespace SSOA.Web.Models.Checkout
{
    public partial class CheckoutBillingAddressModel : BaseSSOAModel
    {
        public CheckoutBillingAddressModel()
        {
            ExistingAddresses = new List<AddressModel>();
            NewAddress = new AddressModel();
        }

        public IList<AddressModel> ExistingAddresses { get; set; }

        public AddressModel NewAddress { get; set; }

        /// <summary>
        /// Used on one-page checkout page
        /// </summary>
        public bool NewAddressPreselected { get; set; }
    }
}