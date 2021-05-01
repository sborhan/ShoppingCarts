using NUnit.Framework;
using ShoppingCarts.Services.ServiceImplementation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UnitTest.Service
{
    class ItemServiceTests
    {
        ItemService control;
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void ItemService_Constructor_Should_Pass()
        {
            //Arrange
            control = new ItemService();

            //Act

            //Reset

            //Assert
            Assert.IsNotNull(control);
        }

        [Test]
        public async Task GetItems_Should_Pass()
        {
            // TODO
            //Arrange

            //Act

            //Reset

            //Assert
        }
    }
}
