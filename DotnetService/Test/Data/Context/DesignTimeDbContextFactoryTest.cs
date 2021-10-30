using System;
using Data.Context;
using NUnit.Framework;

namespace Test.Data.Context
{
    class DesignTimeDbContextFactoryTest
    {
        DesignTimeDbContextFactory factory;
        [SetUp]
        public void SetUp()
        {
            factory = new DesignTimeDbContextFactory();
        }

        [Test]
        public void DesignTimeDbContextFactory()
        {
            string[] args = {};
            Environment.SetEnvironmentVariable("DB_LOCAL_CONNECTION_STRING", "DB_LOCAL_CONNECTION_STRING");
            var context = factory.CreateDbContext(args);
            Assert.IsInstanceOf<ApplicationDbContext>(context);
        }
    }
}