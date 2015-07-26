using SSOA.Web.Framework.Mvc;

namespace SSOA.Web.Models.Common
{
    public partial class CurrencyModel : BaseSSOAEntityModel
    {
        public string Name { get; set; }

        public string CurrencySymbol { get; set; }
    }
}