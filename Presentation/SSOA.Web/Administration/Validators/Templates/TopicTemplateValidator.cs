using FluentValidation;
using SSOA.Admin.Models.Templates;
using SSOA.Services.Localization;
using SSOA.Web.Framework.Validators;

namespace SSOA.Admin.Validators.Templates
{
    public class TopicTemplateValidator : BaseSSOAValidator<TopicTemplateModel>
    {
        public TopicTemplateValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.System.Templates.Topic.Name.Required"));
            RuleFor(x => x.ViewPath).NotEmpty().WithMessage(localizationService.GetResource("Admin.System.Templates.Topic.ViewPath.Required"));
        }
    }
}