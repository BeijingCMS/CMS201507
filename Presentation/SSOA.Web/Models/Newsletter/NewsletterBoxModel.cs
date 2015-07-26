using SSOA.Web.Framework.Mvc;

namespace SSOA.Web.Models.Newsletter
{
    public partial class NewsletterBoxModel : BaseSSOAModel
    {
        public string NewsletterEmail { get; set; }
        public bool AllowToUnsubscribe { get; set; }
    }
}