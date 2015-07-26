using System.Collections.Generic;
using SSOA.Admin.Models.Stores;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Admin.Models.Settings
{
    public partial class StoreScopeConfigurationModel : BaseSSOAModel
    {
        public StoreScopeConfigurationModel()
        {
            Stores = new List<StoreModel>();
        }

        public int StoreId { get; set; }
        public IList<StoreModel> Stores { get; set; }
    }
}