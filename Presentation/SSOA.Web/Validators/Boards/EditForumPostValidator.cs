using FluentValidation;
using SSOA.Services.Localization;
using SSOA.Web.Framework.Validators;
using SSOA.Web.Models.Boards;

namespace SSOA.Web.Validators.Boards
{
    public class EditForumPostValidator : BaseSSOAValidator<EditForumPostModel>
    {
        public EditForumPostValidator(ILocalizationService localizationService)
        {            
            RuleFor(x => x.Text).NotEmpty().WithMessage(localizationService.GetResource("Forum.TextCannotBeEmpty"));
        }
    }
}