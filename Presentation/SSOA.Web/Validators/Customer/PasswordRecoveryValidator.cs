using FluentValidation;
using SSOA.Services.Localization;
using SSOA.Web.Framework.Validators;
using SSOA.Web.Models.Customer;

namespace SSOA.Web.Validators.Customer
{
    public class PasswordRecoveryValidator : BaseSSOAValidator<PasswordRecoveryModel>
    {
        public PasswordRecoveryValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage(localizationService.GetResource("Account.PasswordRecovery.Email.Required"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizationService.GetResource("Common.WrongEmail"));
        }}
}