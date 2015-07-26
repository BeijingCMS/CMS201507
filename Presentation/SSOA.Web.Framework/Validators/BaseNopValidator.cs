using FluentValidation;

namespace SSOA.Web.Framework.Validators
{
    public abstract class BaseSSOAValidator<T> : AbstractValidator<T> where T : class
    {
        protected BaseSSOAValidator()
        {
            PostInitialize();
        }

        /// <summary>
        /// Developers can override this method in custom partial classes
        /// in order to add some custom initialization code to constructors
        /// </summary>
        protected virtual void PostInitialize()
        {
            
        }
    }
}