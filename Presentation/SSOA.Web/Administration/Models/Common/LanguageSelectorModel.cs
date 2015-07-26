using System.Collections.Generic;
using SSOA.Admin.Models.Localization;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Admin.Models.Common
{
    public partial class LanguageSelectorModel : BaseSSOAModel
    {
        public LanguageSelectorModel()
        {
            AvailableLanguages = new List<LanguageModel>();
        }

        public IList<LanguageModel> AvailableLanguages { get; set; }

        public LanguageModel CurrentLanguage { get; set; }
    }
}