using SSOA.Web.Framework.Mvc;

namespace SSOA.Admin.Models.Security
{
    public partial class PermissionRecordModel : BaseSSOAModel
    {
        public string Name { get; set; }
        public string SystemName { get; set; }
    }
}