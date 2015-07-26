using System.Collections.Generic;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Web.Models.Blogs
{
    public partial class BlogPostYearModel : BaseSSOAModel
    {
        public BlogPostYearModel()
        {
            Months = new List<BlogPostMonthModel>();
        }
        public int Year { get; set; }
        public IList<BlogPostMonthModel> Months { get; set; }
    }
    public partial class BlogPostMonthModel : BaseSSOAModel
    {
        public int Month { get; set; }

        public int BlogPostCount { get; set; }
    }
}