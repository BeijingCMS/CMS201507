using SSOA.Core.Domain.Tasks;

namespace SSOA.Data.Mapping.Tasks
{
    public partial class ScheduleTaskMap : SSOAEntityTypeConfiguration<ScheduleTask>
    {
        public ScheduleTaskMap()
        {
            this.ToTable("ScheduleTask");
            this.HasKey(t => t.Id);
            this.Property(t => t.Name).IsRequired();
            this.Property(t => t.Type).IsRequired();
        }
    }
}