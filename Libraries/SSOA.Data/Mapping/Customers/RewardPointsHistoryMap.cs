using SSOA.Core.Domain.Customers;

namespace SSOA.Data.Mapping.Customers
{
    public partial class RewardPointsHistoryMap : SSOAEntityTypeConfiguration<RewardPointsHistory>
    {
        public RewardPointsHistoryMap()
        {
            this.ToTable("RewardPointsHistory");
            this.HasKey(rph => rph.Id);

            this.Property(rph => rph.UsedAmount).HasPrecision(18, 4);
            //this.Property(rph => rph.UsedAmountInCustomerCurrency).HasPrecision(18, 4);

            this.HasRequired(rph => rph.Customer)
                .WithMany(c => c.RewardPointsHistory)
                .HasForeignKey(rph => rph.CustomerId);
        }
    }
}