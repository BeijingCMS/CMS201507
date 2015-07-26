using SSOA.Web.Framework.Mvc;

namespace SSOA.Admin.Models.Common
{
    public partial class SystemWarningModel : BaseSSOAModel
    {
        public SystemWarningLevel Level { get; set; }

        public string Text { get; set; }
    }

    public enum SystemWarningLevel
    {
        Pass,
        Warning,
        Fail
    }
}