using SSOA.Web.Framework.Mvc;

namespace SSOA.Web.Models.Catalog
{
    public partial class ProductSpecificationModel : BaseSSOAModel
    {
        public int SpecificationAttributeId { get; set; }

        public string SpecificationAttributeName { get; set; }

        //this value is already HTML encoded
        public string ValueRaw { get; set; }
    }
}