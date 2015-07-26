using System;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Web.Models.Blogs
{
    public partial class BlogCommentModel : BaseSSOAEntityModel
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string CustomerAvatarUrl { get; set; }

        public string CommentText { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool AllowViewingProfiles { get; set; }
    }
}