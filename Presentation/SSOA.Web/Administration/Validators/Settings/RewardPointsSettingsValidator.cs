using FluentValidation;
using SSOA.Admin.Models.Settings;

using SSOA.Services.Localization;
using SSOA.Web.Framework.Validators;

namespace SSOA.Admin.Validators.Settings
{
    public class RewardPointsSettingsValidator : BaseSSOAValidator<RewardPointsSettingsModel>
    {
        public RewardPointsSettingsValidator(ILocalizationService localizationService)
        {
                    }
    }
}