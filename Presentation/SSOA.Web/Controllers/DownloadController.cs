using System;
using System.Web.Mvc;
using SSOA.Core;
using SSOA.Core.Domain.Customers;

using SSOA.Services.Localization;
using SSOA.Services.Media;


namespace SSOA.Web.Controllers
{
    public partial class DownloadController : BasePublicController
    {
        private readonly IDownloadService _downloadService; 
        private readonly IWorkContext _workContext;
        private readonly ILocalizationService _localizationService;
        private readonly CustomerSettings _customerSettings;

        public DownloadController(IDownloadService downloadService,
            IWorkContext workContext,
            ILocalizationService localizationService,
            CustomerSettings customerSettings)
        {
            this._downloadService = downloadService;
            this._workContext = workContext;
            this._localizationService = localizationService;
            this._customerSettings = customerSettings;
        }
        
        public ActionResult Sample(int productId)
        {
                return Content("Product doesn't have a sample download.");

            
        }

        public ActionResult GetDownload(Guid orderItemId, bool agree = false)
        {
            
                return InvokeHttp404();

            
        }

        public ActionResult GetLicense(Guid orderItemId)
        {
           
                return InvokeHttp404();

            
        }

        public ActionResult GetFileUpload(Guid downloadId)
        {
            var download = _downloadService.GetDownloadByGuid(downloadId);
            if (download == null)
                return Content("Download is not available any more.");

            if (download.UseDownloadUrl)
                return new RedirectResult(download.DownloadUrl);

            //binary download
            if (download.DownloadBinary == null)
                return Content("Download data is not available any more.");

            //return result
            string fileName = !String.IsNullOrWhiteSpace(download.Filename) ? download.Filename : downloadId.ToString();
            string contentType = !String.IsNullOrWhiteSpace(download.ContentType) ? download.ContentType : "application/octet-stream";
            return new FileContentResult(download.DownloadBinary, contentType) { FileDownloadName = fileName + download.Extension };
        }

        public ActionResult GetOrderNoteFile(int orderNoteId)
        {
            
                return InvokeHttp404();

        }
    }
}
