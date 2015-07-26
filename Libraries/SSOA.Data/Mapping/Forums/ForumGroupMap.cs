using SSOA.Core.Domain.Forums;

namespace SSOA.Data.Mapping.Forums
{
    public partial class ForumGroupMap : SSOAEntityTypeConfiguration<ForumGroup>
    {
        public ForumGroupMap()
        {
            this.ToTable("Forums_Group");
            this.HasKey(fg => fg.Id);
            this.Property(fg => fg.Name).IsRequired().HasMaxLength(200);
        }
    }
}
