using System.Collections.Generic;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Web.Models.Catalog
{
    public partial class TopMenuModel : BaseSSOAModel
    {
        public TopMenuModel()
        {
            Categories = new List<CategorySimpleModel>();
            Topics = new List<TopMenuTopicModel>();
        }

        public IList<CategorySimpleModel> Categories { get; set; }
        public IList<TopMenuTopicModel> Topics { get; set; }

        public bool BlogEnabled { get; set; }
        public bool RecentlyAddedProductsEnabled { get; set; }
        public bool ForumEnabled { get; set; }

        #region Nested classes

        public class TopMenuTopicModel : BaseSSOAEntityModel
        {
            public string Name { get; set; }
            public string SeName { get; set; }
        }

        #endregion
    }
}