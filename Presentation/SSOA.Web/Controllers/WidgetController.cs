using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using SSOA.Core;
using SSOA.Core.Caching;
using SSOA.Services.Cms;
using SSOA.Web.Infrastructure.Cache;
using SSOA.Web.Models.Cms;

namespace SSOA.Web.Controllers
{
    public partial class WidgetController : BasePublicController
    {
		#region Fields

        private readonly IWidgetService _widgetService;
        private readonly ITenantContext _storeContext;
        private readonly ICacheManager _cacheManager;

        #endregion

		#region Constructors

        public WidgetController(IWidgetService widgetService, 
            ITenantContext storeContext,
            ICacheManager cacheManager)
        {
            this._widgetService = widgetService;
            this._storeContext = storeContext;
            this._cacheManager = cacheManager;
        }

        #endregion

        #region Methods

        [ChildActionOnly]
        public ActionResult WidgetsByZone(string widgetZone, object additionalData = null)
        {
            var cacheKey = string.Format(ModelCacheEventConsumer.WIDGET_MODEL_KEY, _storeContext.CurrentTenant.Id, widgetZone);
            var cacheModel = _cacheManager.Get(cacheKey, () =>
            {
                //model
                var model = new List<RenderWidgetModel>();

                var widgets = _widgetService.LoadActiveWidgetsByWidgetZone(widgetZone, _storeContext.CurrentTenant.Id);
                foreach (var widget in widgets)
                {
                    var widgetModel = new RenderWidgetModel();

                    string actionName;
                    string controllerName;
                    RouteValueDictionary routeValues;
                    widget.GetDisplayWidgetRoute(widgetZone, out actionName, out controllerName, out routeValues);
                    widgetModel.ActionName = actionName;
                    widgetModel.ControllerName = controllerName;
                    widgetModel.RouteValues = routeValues;

                    model.Add(widgetModel);
                }
                return model;
            });

            //no data?
            if (cacheModel.Count == 0)
                return Content("");

            //"RouteValues" property of widget models depends on "additionalData".
            //We need to clone the cached model before modifications (the updated one should not be cached)
            var clonedModel = new List<RenderWidgetModel>();
            foreach (var widgetModel in cacheModel)
            {
                var clonedWidgetModel = new RenderWidgetModel();
                clonedWidgetModel.ActionName = widgetModel.ActionName;
                clonedWidgetModel.ControllerName = widgetModel.ControllerName;
                if (widgetModel.RouteValues != null)
                    clonedWidgetModel.RouteValues = new RouteValueDictionary(widgetModel.RouteValues);

                if (additionalData != null)
                {
                    if (clonedWidgetModel.RouteValues == null)
                        clonedWidgetModel.RouteValues = new RouteValueDictionary();
                    clonedWidgetModel.RouteValues.Add("additionalData", additionalData);
                }

                clonedModel.Add(clonedWidgetModel);
            }

            return PartialView(clonedModel);
        }

        #endregion
    }
}
