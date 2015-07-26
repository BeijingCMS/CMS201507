using System.Collections.Generic;
using SSOA.Web.Framework.Mvc;
using SSOA.Web.Models.Common;

namespace SSOA.Web.Models.Customer
{
    public partial class CustomerAddressListModel : BaseSSOAModel
    {
        public CustomerAddressListModel()
        {
            Addresses = new List<AddressModel>();
        }

        public IList<AddressModel> Addresses { get; set; }
    }
}