using SSOA.Core.Domain.Stores;

namespace SSOA.Core
{
    /// <summary>
    /// Store context
    /// 不需要当做商店，把Store当成一个应用
    /// 或者叫做Tenant(租户)
    /// </summary>
    public interface ITenantContext
    {
        /// <summary>
        /// Gets or sets the current store
        /// </summary>
        Store CurrentTenant { get; }
    }
}
