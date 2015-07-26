using System.Collections.Generic;
using SSOA.Core.Domain.Catalog;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Web.Models.Customer
{
    public partial class CustomerAttributeModel : BaseSSOAEntityModel
    {
        public CustomerAttributeModel()
        {
            Values = new List<CustomerAttributeValueModel>();
        }

        public string Name { get; set; }

        public bool IsRequired { get; set; }

        /// <summary>
        /// Default value for textboxes
        /// </summary>
        public string DefaultValue { get; set; }

        public AttributeControlType AttributeControlType { get; set; }

        public IList<CustomerAttributeValueModel> Values { get; set; }

    }

    public partial class CustomerAttributeValueModel : BaseSSOAEntityModel
    {
        public string Name { get; set; }

        public bool IsPreSelected { get; set; }
    }
}