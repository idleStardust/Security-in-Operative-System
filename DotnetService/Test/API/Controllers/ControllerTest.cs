using Data.Contracts;
using Managers.Implementation;
using Managers.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using DataModels = Data.Models;

namespace Test.API.Controllers
{
    public abstract class ControllerTest<Controller, Model, Manager, DataModel, Accessor> 
        where Controller :  ControllerBase
        where Model : IModel<Model>
        where Manager : class, IManager
        where DataModel : DataModels.IModel<DataModel>
        where Accessor: IAccessor<DataModel>
    {
        protected Controller controller;
        protected Mock<Manager> manager;
        [SetUp]
        public void SetUp()
        {
            this.manager = new Mock<Manager>();
        }
    }
}