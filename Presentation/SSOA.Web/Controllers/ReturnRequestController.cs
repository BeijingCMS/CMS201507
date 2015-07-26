using System;
using System.Web.Mvc;
using SSOA.Core;
using SSOA.Core.Domain.Customers;
using SSOA.Core.Domain.Localization;



using SSOA.Services.Customers;
using SSOA.Services.Directory;
using SSOA.Services.Helpers;
using SSOA.Services.Localization;
using SSOA.Services.Messages;

using SSOA.Services.Seo;
using SSOA.Web.Framework.Security;
using SSOA.Web.Models.Order;

namespace SSOA.Web.Controllers
{
    public partial class ReturnRequestController : BasePublicController
    {
		#region Fields

        
        private readonly IWorkContext _workContext;
        private readonly ITenantContext _storeContext;
        private readonly ICurrencyService _currencyService;
       
        private readonly ILocalizationService _localizationService;
        private readonly ICustomerService _customerService;
        private readonly IWorkflowMessageService _workflowMessageService;
        private readonly IDateTimeHelper _dateTimeHelper;

        private readonly LocalizationSettings _localizationSettings;

        #endregion

		#region Constructors

        public ReturnRequestController(
            IWorkContext workContext, 
            ITenantContext storeContext,
            ICurrencyService currencyService, 
            ILocalizationService localizationService,
            ICustomerService customerService,
            IWorkflowMessageService workflowMessageService,
            IDateTimeHelper dateTimeHelper,
            LocalizationSettings localizationSettings)
        {
            this._workContext = workContext;
            this._storeContext = storeContext;
            this._currencyService = currencyService;
            this._localizationService = localizationService;
            this._customerService = customerService;
            this._workflowMessageService = workflowMessageService;
            this._dateTimeHelper = dateTimeHelper;

            this._localizationSettings = localizationSettings;
        }

        #endregion

        #region Utilities

        [NonAction]
        protected virtual SubmitReturnRequestModel PrepareReturnRequestModel(SubmitReturnRequestModel model)
        {
            
            if (model == null)
                throw new ArgumentNullException("model");

           
            return model;
        }

        #endregion
        
        #region Methods

        [SSOAHttpsRequirement(SslRequirement.Yes)]
        public ActionResult CustomerReturnRequests()
        {
            if (!_workContext.CurrentCustomer.IsRegistered())
                return new HttpUnauthorizedResult();

            return new HttpUnauthorizedResult();
        }

        [SSOAHttpsRequirement(SslRequirement.Yes)]
        public ActionResult ReturnRequest(int orderId)
        {
            return new HttpUnauthorizedResult();
        }

        [HttpPost, ActionName("ReturnRequest")]
        [ValidateInput(false)]
        public ActionResult ReturnRequestSubmit(int orderId, SubmitReturnRequestModel model, FormCollection form)
        {
           
                return new HttpUnauthorizedResult();

        }

        #endregion
    }
}
