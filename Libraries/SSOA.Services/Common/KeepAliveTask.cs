using System.Net;
using SSOA.Core;
using SSOA.Services.Tasks;

namespace SSOA.Services.Common
{
    /// <summary>
    /// Represents a task for keeping the site alive
    /// </summary>
    public partial class KeepAliveTask : ITask
    {
        private readonly ITenantContext _storeContext;

        public KeepAliveTask(ITenantContext storeContext)
        {
            this._storeContext = storeContext;
        }

        /// <summary>
        /// Executes a task
        /// </summary>
        public void Execute()
        {
            string url = _storeContext.CurrentTenant.Url + "keepalive/index";
            using (var wc = new WebClient())
            {
                wc.DownloadString(url);
            }
        }
    }
}
