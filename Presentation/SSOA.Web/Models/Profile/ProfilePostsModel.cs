using System.Collections.Generic;
using SSOA.Web.Models.Common;

namespace SSOA.Web.Models.Profile
{
    public partial class ProfilePostsModel
    {
        public IList<PostsModel> Posts { get; set; }
        public PagerModel PagerModel { get; set; }
    }
}