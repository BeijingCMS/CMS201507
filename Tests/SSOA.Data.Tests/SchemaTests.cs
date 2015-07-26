using System;
using System.Data.Entity;
using SSOA.Tests;
using NUnit.Framework;

namespace SSOA.Data.Tests
{
    [TestFixture]
    public class SchemaTests
    {
        [Test]
        public void Can_generate_schema()
        {
            Database.SetInitializer<SSOAObjectContext>(null);
            var ctx = new SSOAObjectContext("Test");
            string result = ctx.CreateDatabaseScript();
            result.ShouldNotBeNull();
            Console.Write(result);
        }
    }
}
