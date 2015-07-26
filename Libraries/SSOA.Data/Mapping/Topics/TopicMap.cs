using SSOA.Core.Domain.Topics;

namespace SSOA.Data.Mapping.Topics
{
    public class TopicMap : SSOAEntityTypeConfiguration<Topic>
    {
        public TopicMap()
        {
            this.ToTable("Topic");
            this.HasKey(t => t.Id);
        }
    }
}
