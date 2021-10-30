using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Context;
using Data.Contracts;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace Test.Data.Accessors
{
    [TestFixture()]
    abstract class AccessorTest<Accessor, Model>
        where Accessor : IAccessor<Model>
        where Model : IModel<Model>
    {
        protected Accessor accessor;
        protected ApplicationDbContext context;

        [SetUp]
        public void SetUp()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "DB Test").Options;
            this.context = new ApplicationDbContext(options);
        }

        public async Task GetAllTest()
        {
            IEnumerable<Model> value = await this.accessor.GetAll();
            Assert.IsInstanceOf<IEnumerable<Model>>(value);
        }

        public void GetTest(int id)
        {
            Assert.ThrowsAsync<NotImplementedException>(
                async () => await this.accessor.Get(id));
        }

        public void PutTest(Model model)
        {
            Assert.ThrowsAsync<NotImplementedException>(
                async () => await this.accessor.Put(model));
        }

        public void PostTest(Model model)
        {
            Assert.ThrowsAsync<NotImplementedException>(
                async () => await this.accessor.Post(model));
        }
    }
}