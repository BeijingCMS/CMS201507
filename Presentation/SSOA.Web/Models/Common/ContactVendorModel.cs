using System.Web.Mvc;
using FluentValidation.Attributes;
using SSOA.Web.Framework;
using SSOA.Web.Framework.Mvc;
using SSOA.Web.Validators.Common;

namespace SSOA.Web.Models.Common
{
    [Validator(typeof(ContactVendorValidator))]
    public partial class ContactVendorModel : BaseSSOAModel
    {
        public int VendorId { get; set; }
        public string VendorName { get; set; }

        [AllowHtml]
        [SSOAResourceDisplayName("ContactVendor.Email")]
        public string Email { get; set; }

        [AllowHtml]
        [SSOAResourceDisplayName("ContactVendor.Subject")]
        public string Subject { get; set; }
        public bool SubjectEnabled { get; set; }

        [AllowHtml]
        [SSOAResourceDisplayName("ContactVendor.Enquiry")]
        public string Enquiry { get; set; }

        [AllowHtml]
        [SSOAResourceDisplayName("ContactVendor.FullName")]
        public string FullName { get; set; }

        public bool SuccessfullySent { get; set; }
        public string Result { get; set; }

        public bool DisplayCaptcha { get; set; }
    }
}