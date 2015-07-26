using SSOA.Core.Domain.Configuration;
using SSOA.Tests;
using NUnit.Framework;

namespace SSOA.Data.Tests.Configuration
{
    [TestFixture]
    public class SettingPersistenceTests : PersistenceTest
    {
        [Test]
        public void Can_save_and_load_setting()
        {
            var setting = new Setting
            {
                Name = "Setting1",
                Value = "Value1",
                StoreId = 1,
            };

            var fromDb = SaveAndLoadEntity(setting);
            fromDb.ShouldNotBeNull();
            fromDb.Name.ShouldEqual("Setting1");
            fromDb.Value.ShouldEqual("Value1");
            fromDb.StoreId.ShouldEqual(1);
        }
    }
}
