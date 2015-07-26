using SSOA.Core.Domain.Media;

namespace SSOA.Data.Mapping.Media
{
    public partial class DownloadMap : SSOAEntityTypeConfiguration<Download>
    {
        public DownloadMap()
        {
            this.ToTable("Download");
            this.HasKey(p => p.Id);
            this.Property(p => p.DownloadBinary).IsMaxLength();
        }
    }
}