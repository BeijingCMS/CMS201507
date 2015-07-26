using System.Web.Mvc;

namespace SSOA.Web.Framework.Mvc
{
    public class SSOAModelBinder : DefaultModelBinder
    {
        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var model = base.BindModel(controllerContext, bindingContext);
            if (model is BaseSSOAModel)
            {
                ((BaseSSOAModel)model).BindModel(controllerContext, bindingContext);
            }
            return model;
        }
    }
}
