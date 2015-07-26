using SSOA.Web.Framework.Mvc;

namespace SSOA.Web.Models.Common
{
    public partial class AdminHeaderLinksModel : BaseSSOAModel
    {
        public string ImpersonatedCustomerEmailUsername { get; set; }
        public bool IsCustomerImpersonated { get; set; }
        public bool DisplayAdminLink { get; set; }
    }
}