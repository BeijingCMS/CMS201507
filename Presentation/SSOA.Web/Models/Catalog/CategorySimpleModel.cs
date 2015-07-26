using System.Collections.Generic;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Web.Models.Catalog
{
    public class CategorySimpleModel : BaseSSOAEntityModel
    {
        public CategorySimpleModel()
        {
            SubCategories = new List<CategorySimpleModel>();
        }

        public string Name { get; set; }

        public string SeName { get; set; }

        public int? NumberOfProducts { get; set; }

        public bool IncludeInTopMenu { get; set; }

        public List<CategorySimpleModel> SubCategories { get; set; }
    }
}