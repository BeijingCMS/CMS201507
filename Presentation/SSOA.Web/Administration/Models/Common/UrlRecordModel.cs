using System.Web.Mvc;
using SSOA.Web.Framework;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Admin.Models.Common
{
    public partial class UrlRecordModel : BaseSSOAEntityModel
    {
        [SSOAResourceDisplayName("Admin.System.SeNames.Name")]
        [AllowHtml]
        public string Name { get; set; }

        [SSOAResourceDisplayName("Admin.System.SeNames.EntityId")]
        public int EntityId { get; set; }

        [SSOAResourceDisplayName("Admin.System.SeNames.EntityName")]
        public string EntityName { get; set; }

        [SSOAResourceDisplayName("Admin.System.SeNames.IsActive")]
        public bool IsActive { get; set; }

        [SSOAResourceDisplayName("Admin.System.SeNames.Language")]
        public string Language { get; set; }

        [SSOAResourceDisplayName("Admin.System.SeNames.Details")]
        public string DetailsUrl { get; set; }
    }
}