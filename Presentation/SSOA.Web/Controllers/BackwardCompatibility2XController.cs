using System.Web.Mvc;
using SSOA.Services.Blogs;
using SSOA.Services.News;
using SSOA.Services.Seo;
using SSOA.Services.Topics;

namespace SSOA.Web.Controllers
{
    public partial class BackwardCompatibility2XController : BasePublicController
    {
		#region Fields

        private readonly INewsService _newsService;
        private readonly IBlogService _blogService;
        private readonly ITopicService _topicService;

        #endregion

		#region Constructors

        public BackwardCompatibility2XController(INewsService newsService, 
            IBlogService blogService,
            ITopicService topicService)
        {
            this._newsService = newsService;
            this._blogService = blogService;
            this._topicService = topicService;
        }

		#endregion
        
        #region Methods
        
        //in versions 2.00-2.65 we had ID in product URLs
        public ActionResult RedirectProductById(int productId)
        {

            return RedirectToRoutePermanent("Product", new { SeName = "" });
        }
        //in versions 2.00-2.65 we had ID in category URLs
        public ActionResult RedirectCategoryById(int categoryId)
        {

            return RedirectToRoutePermanent("Category", new { SeName = "" });
        }
        //in versions 2.00-2.65 we had ID in manufacturer URLs
        public ActionResult RedirectManufacturerById(int manufacturerId)
        {

            return RedirectToRoutePermanent("Manufacturer", new { SeName = "" });
        }
        //in versions 2.00-2.70 we had ID in news URLs
        public ActionResult RedirectNewsItemById(int newsItemId)
        {
            var newsItem = _newsService.GetNewsById(newsItemId);
            if (newsItem == null)
                return RedirectToRoutePermanent("HomePage");

            return RedirectToRoutePermanent("NewsItem", new { SeName = newsItem.GetSeName(newsItem.LanguageId, ensureTwoPublishedLanguages: false) });
        }
        //in versions 2.00-2.70 we had ID in blog URLs
        public ActionResult RedirectBlogPostById(int blogPostId)
        {
            var blogPost = _blogService.GetBlogPostById(blogPostId);
            if (blogPost == null)
                return RedirectToRoutePermanent("HomePage");

            return RedirectToRoutePermanent("BlogPost", new { SeName = blogPost.GetSeName(blogPost.LanguageId, ensureTwoPublishedLanguages: false) });
        }
        //in versions 2.00-3.20 we had SystemName in topic URLs
        public ActionResult RedirectTopicBySystemName(string systemName)
        {
            var topic = _topicService.GetTopicBySystemName(systemName);
            if (topic == null)
                return RedirectToRoutePermanent("HomePage");

            return RedirectToRoutePermanent("Topic", new { SeName = topic.GetSeName() });
        }
        //in versions 3.00-3.20 we had ID in vendor URLs
        public ActionResult RedirectVendorById(int vendorId)
        {
            
            return RedirectToRoutePermanent("Vendor", new { SeName = "vendor.GetSeName()" });
        }
        #endregion
    }
}
