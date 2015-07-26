using Autofac;
using Autofac.Core;
using SSOA.Core.Caching;
using SSOA.Core.Infrastructure;
using SSOA.Core.Infrastructure.DependencyManagement;
using SSOA.Plugin.Widgets.NivoSlider.Controllers;

namespace SSOA.Plugin.Widgets.NivoSlider.Infrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            //we cache presentation models between requests
            builder.RegisterType<WidgetsNivoSliderController>()
                .WithParameter(ResolvedParameter.ForNamed<ICacheManager>("SSOA_cache_static"));
        }

        public int Order
        {
            get { return 2; }
        }
    }
}
