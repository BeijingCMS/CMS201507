﻿using System;
using SSOA.Core.Domain.Customers;
using SSOA.Core.Domain.Logging;
using SSOA.Tests;
using NUnit.Framework;

namespace SSOA.Data.Tests.Logging
{
    [TestFixture]
    public class ActivityLogPersistenceTests : PersistenceTest
    {
        [Test]
        public void Can_save_and_load_activityLogType()
        {
            var activityLogType = new ActivityLogType
                               {
                                   SystemKeyword = "SystemKeyword 1",
                                   Name = "Name 1",
                                   Enabled = true,
                               };

            var fromDb = SaveAndLoadEntity(activityLogType);
            fromDb.ShouldNotBeNull();
            fromDb.SystemKeyword.ShouldEqual("SystemKeyword 1");
            fromDb.Name.ShouldEqual("Name 1");
            fromDb.Enabled.ShouldEqual(true);
        }

        protected Customer GetTestCustomer()
        {
            return new Customer
            {
                CustomerGuid = Guid.NewGuid(),
                CreatedOnUtc = new DateTime(2010, 01, 01),
                LastActivityDateUtc = new DateTime(2010, 01, 02)
            };
        }
    }
}