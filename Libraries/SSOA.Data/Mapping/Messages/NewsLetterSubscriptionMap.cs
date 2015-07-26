using SSOA.Core.Domain.Messages;

namespace SSOA.Data.Mapping.Messages
{
    public partial class NewsLetterSubscriptionMap : SSOAEntityTypeConfiguration<NewsLetterSubscription>
    {
        public NewsLetterSubscriptionMap()
        {
            this.ToTable("NewsLetterSubscription");
            this.HasKey(nls => nls.Id);

            this.Property(nls => nls.Email).IsRequired().HasMaxLength(255);
        }
    }
}