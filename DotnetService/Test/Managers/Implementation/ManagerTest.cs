using Data.Contracts;
using NUnit.Framework;
using Moq;
using System.Collections.Generic;
using Managers.Implementation;
using Data.Models;

namespace Test.Managers.Implementation
{
    [TestFixture()]
    abstract class ManagerTest<Accessor, DataModel, Manager>
        where Accessor : class, IAccessor<DataModel>
        where DataModel : IModel<DataModel>, new()
        where Manager : IManager
    {
        protected Mock<Accessor> accessor;
        protected Manager manager;
     
        [SetUp]
        public void SetUp()
        {
            this.accessor = new Mock<Accessor>();
            List<DataModel> data = new List<DataModel>();
            data.Add(new DataModel().Empty);
            
            this.accessor.Setup(_ => _.GetAll()).ReturnsAsync(data);           
        }
    }
}