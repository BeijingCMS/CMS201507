using System.Collections.Generic;
using System.Web.Mvc;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Web.Models.Boards
{
    public partial class TopicMoveModel : BaseSSOAEntityModel
    {
        public TopicMoveModel()
        {
            ForumList = new List<SelectListItem>();
        }

        public int ForumSelected { get; set; }
        public string TopicSeName { get; set; }

        public IEnumerable<SelectListItem> ForumList { get; set; }
    }
}