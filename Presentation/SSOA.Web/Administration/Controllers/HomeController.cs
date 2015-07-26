using System;
using System.Net;
using System.ServiceModel.Syndication;
using System.Web.Mvc;
using System.Xml;
using SSOA.Admin.Infrastructure.Cache;
using SSOA.Admin.Models.Home;
using SSOA.Core;
using SSOA.Core.Caching;
using SSOA.Core.Domain.Common;
using SSOA.Services.Configuration;

namespace SSOA.Admin.Controllers
{
    public partial class HomeController : BaseAdminController
    {
        #region Fields

        private readonly ITenantContext _storeContext;
        private readonly CommonSettings _commonSettings;
        private readonly ISettingService _settingService;
        private readonly IWorkContext _workContext;
        private readonly ICacheManager _cacheManager;

        #endregion

        #region Ctor

        public HomeController(
            ITenantContext storeContext, 
            CommonSettings commonSettings, 
            ISettingService settingService,
            IWorkContext workContext,
            ICacheManager cacheManager)
        {
            this._storeContext = storeContext;
            this._commonSettings = commonSettings;
            this._settingService = settingService;
            this._workContext = workContext;
            this._cacheManager= cacheManager;
        }

        #endregion

        #region Methods

        public ActionResult Index()
        {
            var model = new DashboardModel();
            return View(model);
        }

        [ChildActionOnly]
        public ActionResult SSOACommerceNews()
        {
            try
            {
                string feedUrl = string.Format("http://www.SSOACommerce.com/NewsRSS.aspx?Version={0}&Localhost={1}&HideAdvertisements={2}&StoreURL={3}",
                    SSOAVersion.CurrentVersion, 
                    Request.Url.IsLoopback, 
                    _commonSettings.HideAdvertisementsOnAdminArea,
                    _storeContext.CurrentTenant.Url)
                    .ToLowerInvariant();

                var rssData = _cacheManager.Get(ModelCacheEventConsumer.OFFICIAL_NEWS_MODEL_KEY, () =>
                {
                    //specify timeout (5 secs)
                    var request = WebRequest.Create(feedUrl);
                    request.Timeout = 5000;
                    using (var response = request.GetResponse())
                    {
                        using (var reader = XmlReader.Create(response.GetResponseStream()))
                        {
                            return SyndicationFeed.Load(reader);
                        }
                    }
                });
 
                return PartialView(rssData);
            }
            catch (Exception)
            {
                return Content("");
            }
        }

        [HttpPost]
        public ActionResult SSOACommerceNewsHideAdv()
        {
            _commonSettings.HideAdvertisementsOnAdminArea = 
                !_commonSettings.HideAdvertisementsOnAdminArea;
            _settingService.SaveSetting(_commonSettings);
            return Content("Setting changed");
        }

        #endregion
    }
}
