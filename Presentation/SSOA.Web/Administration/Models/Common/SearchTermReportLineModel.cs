using SSOA.Web.Framework;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Admin.Models.Common
{
    public partial class SearchTermReportLineModel : BaseSSOAModel
    {
        [SSOAResourceDisplayName("Admin.SearchTermReport.Keyword")]
        public string Keyword { get; set; }

        [SSOAResourceDisplayName("Admin.SearchTermReport.Count")]
        public int Count { get; set; }
    }
}
