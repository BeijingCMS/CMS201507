using SSOA.Admin.Models.Common;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Admin.Models.Orders
{
    public partial class OrderAddressModel : BaseSSOAModel
    {
        public int OrderId { get; set; }

        public AddressModel Address { get; set; }
    }
}