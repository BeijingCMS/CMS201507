using System.Collections.Generic;
using System.Web.Mvc;
using SSOA.Web.Framework;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Admin.Models.Topics
{
    public partial class TopicListModel : BaseSSOAModel
    {
        public TopicListModel()
        {
            AvailableStores = new List<SelectListItem>();
        }

        [SSOAResourceDisplayName("Admin.ContentManagement.Topics.List.SearchStore")]
        public int SearchStoreId { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }
    }
}