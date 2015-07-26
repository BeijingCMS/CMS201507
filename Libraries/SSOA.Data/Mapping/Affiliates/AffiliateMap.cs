using SSOA.Core.Domain.Affiliates;

namespace SSOA.Data.Mapping.Affiliates
{
    public partial class AffiliateMap : SSOAEntityTypeConfiguration<Affiliate>
    {
        public AffiliateMap()
        {
            this.ToTable("Affiliate");
            this.HasKey(a => a.Id);

            this.HasRequired(a => a.Address).WithMany().HasForeignKey(x => x.AddressId).WillCascadeOnDelete(false);
        }
    }
}