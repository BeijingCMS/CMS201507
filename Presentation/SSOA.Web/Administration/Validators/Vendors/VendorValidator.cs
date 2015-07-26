using FluentValidation;
using SSOA.Admin.Models.Vendors;
using SSOA.Services.Localization;
using SSOA.Web.Framework.Validators;

namespace SSOA.Admin.Validators.Vendors
{
    public class VendorValidator : BaseSSOAValidator<VendorModel>
    {
        public VendorValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Vendors.Fields.Name.Required"));

            RuleFor(x => x.Email).NotEmpty().WithMessage(localizationService.GetResource("Admin.Vendors.Fields.Email.Required"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizationService.GetResource("Admin.Common.WrongEmail"));
        }
    }
}