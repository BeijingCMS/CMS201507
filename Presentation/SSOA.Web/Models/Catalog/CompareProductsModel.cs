using System.Collections.Generic;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Web.Models.Catalog
{
    public partial class CompareProductsModel : BaseSSOAEntityModel
    {
        public CompareProductsModel()
        {
            Products = new List<ProductOverviewModel>();
        }
        public IList<ProductOverviewModel> Products { get; set; }

        public bool IncludeShortDescriptionInCompareProducts { get; set; }
        public bool IncludeFullDescriptionInCompareProducts { get; set; }
    }
}