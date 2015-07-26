﻿using System.Collections.Generic;
using System.Web.Mvc;
using FluentValidation.Attributes;
using SSOA.Admin.Models.Stores;
using SSOA.Admin.Validators.Localization;
using SSOA.Web.Framework;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Admin.Models.Localization
{
    [Validator(typeof(LanguageValidator))]
    public partial class LanguageModel : BaseSSOAEntityModel
    {
        public LanguageModel()
        {
            FlagFileNames = new List<string>();
            AvailableCurrencies = new List<SelectListItem>();
        }

        [SSOAResourceDisplayName("Admin.Configuration.Languages.Fields.Name")]
        [AllowHtml]
        public string Name { get; set; }

        [SSOAResourceDisplayName("Admin.Configuration.Languages.Fields.LanguageCulture")]
        [AllowHtml]
        public string LanguageCulture { get; set; }

        [SSOAResourceDisplayName("Admin.Configuration.Languages.Fields.UniqueSeoCode")]
        [AllowHtml]
        public string UniqueSeoCode { get; set; }
        
        //flags
        [SSOAResourceDisplayName("Admin.Configuration.Languages.Fields.FlagImageFileName")]
        [AllowHtml]
        public string FlagImageFileName { get; set; }
        public IList<string> FlagFileNames { get; set; }

        [SSOAResourceDisplayName("Admin.Configuration.Languages.Fields.Rtl")]
        public bool Rtl { get; set; }

        //default currency
        [SSOAResourceDisplayName("Admin.Configuration.Languages.Fields.DefaultCurrency")]
        [AllowHtml]
        public int DefaultCurrencyId { get; set; }
        public IList<SelectListItem> AvailableCurrencies { get; set; }

        [SSOAResourceDisplayName("Admin.Configuration.Languages.Fields.Published")]
        public bool Published { get; set; }

        [SSOAResourceDisplayName("Admin.Configuration.Languages.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }


        //Store mapping
        [SSOAResourceDisplayName("Admin.Configuration.Languages.Fields.LimitedToStores")]
        public bool LimitedToStores { get; set; }
        [SSOAResourceDisplayName("Admin.Configuration.Languages.Fields.AvailableStores")]
        public List<StoreModel> AvailableStores { get; set; }
        public int[] SelectedStoreIds { get; set; }

    }
}