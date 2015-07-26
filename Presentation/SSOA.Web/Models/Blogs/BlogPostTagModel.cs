using SSOA.Web.Framework.Mvc;

namespace SSOA.Web.Models.Blogs
{
    public partial class BlogPostTagModel : BaseSSOAModel
    {
        public string Name { get; set; }

        public int BlogPostCount { get; set; }
    }
}