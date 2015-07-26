using System.Data.Entity.ModelConfiguration;

namespace SSOA.Data.Mapping
{
    public abstract class SSOAEntityTypeConfiguration<T> : EntityTypeConfiguration<T> where T : class
    {
        protected SSOAEntityTypeConfiguration()
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