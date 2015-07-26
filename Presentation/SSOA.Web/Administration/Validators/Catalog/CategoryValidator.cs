using FluentValidation;
using SSOA.Admin.Models.Catalog;
using SSOA.Services.Localization;
using SSOA.Web.Framework.Validators;

namespace SSOA.Admin.Validators.Catalog
{
    public class CategoryValidator : BaseSSOAValidator<CategoryModel>
    {
        public CategoryValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Catalog.Categories.Fields.Name.Required"));
        }
    }
}