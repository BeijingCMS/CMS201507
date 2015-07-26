using SSOA.Admin.Models.Common;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Admin.Models.Customers
{
    public partial class CustomerAddressModel : BaseSSOAModel
    {
        public int CustomerId { get; set; }

        public AddressModel Address { get; set; }
    }
}