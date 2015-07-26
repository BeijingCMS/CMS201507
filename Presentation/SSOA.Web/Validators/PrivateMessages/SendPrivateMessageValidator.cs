using FluentValidation;
using SSOA.Services.Localization;
using SSOA.Web.Framework.Validators;
using SSOA.Web.Models.PrivateMessages;

namespace SSOA.Web.Validators.PrivateMessages
{
    public class SendPrivateMessageValidator : BaseSSOAValidator<SendPrivateMessageModel>
    {
        public SendPrivateMessageValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Subject).NotEmpty().WithMessage(localizationService.GetResource("PrivateMessages.SubjectCannotBeEmpty"));
            RuleFor(x => x.Message).NotEmpty().WithMessage(localizationService.GetResource("PrivateMessages.MessageCannotBeEmpty"));
        }
    }
}