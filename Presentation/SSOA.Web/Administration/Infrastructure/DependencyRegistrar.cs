using Autofac;
using Autofac.Core;
using SSOA.Admin.Controllers;
using SSOA.Core.Caching;
using SSOA.Core.Infrastructure;
using SSOA.Core.Infrastructure.DependencyManagement;

namespace SSOA.Admin.Infrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            //we cache presentation models between requests
            builder.RegisterType<HomeController>()
                .WithParameter(ResolvedParameter.ForNamed<ICacheManager>("SSOA_cache_static"));
        }

        public int Order
        {
            get { return 2; }
        }
    }
}
