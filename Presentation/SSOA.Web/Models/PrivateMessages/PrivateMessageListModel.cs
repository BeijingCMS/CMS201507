using System.Collections.Generic;
using SSOA.Web.Models.Common;

namespace SSOA.Web.Models.PrivateMessages
{
    public partial class PrivateMessageListModel
    {
        public IList<PrivateMessageModel> Messages { get; set; }
        public PagerModel PagerModel { get; set; }
    }
}