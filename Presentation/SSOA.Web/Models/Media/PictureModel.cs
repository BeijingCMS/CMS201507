using SSOA.Web.Framework.Mvc;

namespace SSOA.Web.Models.Media
{
    public partial class PictureModel : BaseSSOAModel
    {
        public string ImageUrl { get; set; }

        public string FullSizeImageUrl { get; set; }

        public string Title { get; set; }

        public string AlternateText { get; set; }
    }
}