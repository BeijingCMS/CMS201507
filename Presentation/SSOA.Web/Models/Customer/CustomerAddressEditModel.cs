using SSOA.Web.Framework.Mvc;
using SSOA.Web.Models.Common;

namespace SSOA.Web.Models.Customer
{
    public partial class CustomerAddressEditModel : BaseSSOAModel
    {
        public CustomerAddressEditModel()
        {
            this.Address = new AddressModel();
        }
        public AddressModel Address { get; set; }
    }
}