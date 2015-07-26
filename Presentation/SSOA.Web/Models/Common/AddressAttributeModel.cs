using System.Collections.Generic;
using SSOA.Core.Domain.Catalog;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Web.Models.Common
{
    public partial class AddressAttributeModel : BaseSSOAEntityModel
    {
        public AddressAttributeModel()
        {
            Values = new List<AddressAttributeValueModel>();
        }

        public string Name { get; set; }

        public bool IsRequired { get; set; }

        /// <summary>
        /// Default value for textboxes
        /// </summary>
        public string DefaultValue { get; set; }

        public AttributeControlType AttributeControlType { get; set; }

        public IList<AddressAttributeValueModel> Values { get; set; }
    }

    public partial class AddressAttributeValueModel : BaseSSOAEntityModel
    {
        public string Name { get; set; }

        public bool IsPreSelected { get; set; }
    }
}