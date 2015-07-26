using System.Web.Mvc;
using FluentValidation.Attributes;
using SSOA.Admin.Validators.Templates;
using SSOA.Web.Framework;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Admin.Models.Templates
{
    [Validator(typeof(TopicTemplateValidator))]
    public partial class TopicTemplateModel : BaseSSOAEntityModel
    {
        [SSOAResourceDisplayName("Admin.System.Templates.Topic.Name")]
        [AllowHtml]
        public string Name { get; set; }

        [SSOAResourceDisplayName("Admin.System.Templates.Topic.ViewPath")]
        [AllowHtml]
        public string ViewPath { get; set; }

        [SSOAResourceDisplayName("Admin.System.Templates.Topic.DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}