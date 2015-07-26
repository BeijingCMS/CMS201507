using SSOA.Core.Domain.Common;

namespace SSOA.Data.Mapping.Common
{
    public partial class SearchTermMap : SSOAEntityTypeConfiguration<SearchTerm>
    {
        public SearchTermMap()
        {
            this.ToTable("SearchTerm");
            this.HasKey(st => st.Id);
        }
    }
}
