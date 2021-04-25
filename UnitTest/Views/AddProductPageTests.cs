using System.Threading.Tasks;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using NUnit.Framework;

using ShoppingCarts.Controls;
using ShoppingCarts;
using System.Windows.Input;
using ShoppingCarts.Views;

namespace UnitTest.Controls
{
    [TestFixture]
    class AddProductPageTests
    {
        AddProductPage productPage;

        [SetUp]
        public void Setup()
        {
            Xamarin.Forms.Mocks.MockForms.Init();
        }

        [Test]
        public void AddProductPage_Constructor_Should_Pass()
        {
            //Arrange
            productPage = new AddProductPage();

            //Act

            //Reset

            //Assert
            Assert.IsNotNull(productPage);
        }

    }
}
