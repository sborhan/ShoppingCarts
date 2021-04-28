using NUnit.Framework;
using ShoppingCarts.Services.ServiceImplementation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UnitTest.Service.ServiceImplementation
{
    class ProdectDetailServiceTest
    {
        ProdectDetailService control;
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void ItemService_Constructor_Should_Pass()
        {
            //Arrange
            control = new ProdectDetailService();

            //Act

            //Reset

            //Assert
            Assert.IsNotNull(control);
        }
    }
}
