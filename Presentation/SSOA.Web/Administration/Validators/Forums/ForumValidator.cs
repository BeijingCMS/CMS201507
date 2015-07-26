using FluentValidation;
using SSOA.Admin.Models.Forums;
using SSOA.Services.Localization;
using SSOA.Web.Framework.Validators;

namespace SSOA.Admin.Validators.Forums
{
    public class ForumValidator : BaseSSOAValidator<ForumModel>
    {
        public ForumValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.ContentManagement.Forums.Forum.Fields.Name.Required"));
            RuleFor(x => x.ForumGroupId).NotEmpty().WithMessage(localizationService.GetResource("Admin.ContentManagement.Forums.Forum.Fields.ForumGroupId.Required"));
        }
    }
}