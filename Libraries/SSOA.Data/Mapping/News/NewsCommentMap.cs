using SSOA.Core.Domain.News;

namespace SSOA.Data.Mapping.News
{
    public partial class NewsCommentMap : SSOAEntityTypeConfiguration<NewsComment>
    {
        public NewsCommentMap()
        {
            this.ToTable("NewsComment");
            this.HasKey(pr => pr.Id);

            this.HasRequired(nc => nc.NewsItem)
                .WithMany(n => n.NewsComments)
                .HasForeignKey(nc => nc.NewsItemId);

            this.HasRequired(cc => cc.Customer)
                .WithMany()
                .HasForeignKey(cc => cc.CustomerId);
        }
    }
}