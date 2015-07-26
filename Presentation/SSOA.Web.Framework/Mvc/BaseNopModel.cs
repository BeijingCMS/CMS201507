using System.Collections.Generic;
using System.Web.Mvc;

namespace SSOA.Web.Framework.Mvc
{
    /// <summary>
    /// Base SSOACommerce model
    /// </summary>
    [ModelBinder(typeof(SSOAModelBinder))]
    public partial class BaseSSOAModel
    {
        public BaseSSOAModel()
        {
            this.CustomProperties = new Dictionary<string, object>();
            PostInitialize();
        }

        public virtual void BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
        }

        /// <summary>
        /// Developers can override this method in custom partial classes
        /// in order to add some custom initialization code to constructors
        /// </summary>
        protected virtual void PostInitialize()
        {
            
        }

        /// <summary>
        /// Use this property to store any custom value for your models. 
        /// </summary>
        public Dictionary<string, object> CustomProperties { get; set; }
    }

    /// <summary>
    /// Base SSOACommerce entity model
    /// </summary>
    public partial class BaseSSOAEntityModel : BaseSSOAModel
    {
        public virtual int Id { get; set; }
    }
}
