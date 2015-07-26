using FluentValidation;
using SSOA.Admin.Models.Catalog;
using SSOA.Services.Localization;
using SSOA.Web.Framework.Validators;

namespace SSOA.Admin.Validators.Catalog
{
    public class ProductReviewValidator : BaseSSOAValidator<ProductReviewModel>
    {
        public ProductReviewValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage(localizationService.GetResource("Admin.Catalog.ProductReviews.Fields.Title.Required"));
            RuleFor(x => x.ReviewText).NotEmpty().WithMessage(localizationService.GetResource("Admin.Catalog.ProductReviews.Fields.ReviewText.Required"));
        }}
}