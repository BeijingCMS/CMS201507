using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSOA.Core;
using SSOA.Core.Caching;
using SSOA.Core.Domain.Catalog;
using SSOA.Core.Domain.Media;
using SSOA.Services.Directory;
using SSOA.Services.Localization;
using SSOA.Services.Media;
using SSOA.Services.Security;
using SSOA.Services.Seo;
using SSOA.Web.Infrastructure.Cache;
using SSOA.Web.Models.Catalog;
using SSOA.Web.Models.Media;

namespace SSOA.Web.Extensions
{
    //here we have some methods shared between controllers
    public static class ControllerExtensions
    {
        public static IList<ProductSpecificationModel> PrepareProductSpecificationModel(this Controller controller,
            IWorkContext workContext,
            
            ICacheManager cacheManager)
        {

            return null;
        }

        public static IEnumerable<ProductOverviewModel> PrepareProductOverviewModels(this Controller controller,
            IWorkContext workContext,
            ITenantContext storeContext,
            IPermissionService permissionService,
            ILocalizationService localizationService,
            ICurrencyService currencyService,
            IPictureService pictureService,
            IWebHelper webHelper,
            ICacheManager cacheManager,
            MediaSettings mediaSettings,
            bool preparePriceModel = true, bool preparePictureModel = true,
            int? productThumbPictureSize = null, bool prepareSpecificationAttributes = false,
            bool forceRedirectionAfterAddingToCart = false)
        {
            
            return null;
        }
    }
}