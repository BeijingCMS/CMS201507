using SSOA.Core.Domain.Polls;

namespace SSOA.Data.Mapping.Polls
{
    public partial class PollAnswerMap : SSOAEntityTypeConfiguration<PollAnswer>
    {
        public PollAnswerMap()
        {
            this.ToTable("PollAnswer");
            this.HasKey(pa => pa.Id);
            this.Property(pa => pa.Name).IsRequired();

            this.HasRequired(pa => pa.Poll)
                .WithMany(p => p.PollAnswers)
                .HasForeignKey(pa => pa.PollId).WillCascadeOnDelete(true);
        }
    }
}