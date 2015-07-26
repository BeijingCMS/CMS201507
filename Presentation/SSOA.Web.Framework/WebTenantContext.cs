using System;
using System.Linq;
using SSOA.Core;
using SSOA.Core.Domain.Stores;


namespace SSOA.Web.Framework
{
    /// <summary>
    /// Store context for web application
    /// </summary>
    public partial class WebTenantContext : ITenantContext
    {
        
        private readonly IWebHelper _webHelper;

        private Store _cachedStore;

        public WebTenantContext(IWebHelper webHelper)
        {
            
            this._webHelper = webHelper;
        }

        /// <summary>
        /// Gets or sets the current store
        /// </summary>
        public virtual Store CurrentTenant
        {
            get
            {
                return null;
            }
        }
    }
}
