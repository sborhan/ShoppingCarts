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
    class CartPageTests
    {
        CartPage Page;

        [SetUp]
        public void Setup()
        {
            Xamarin.Forms.Mocks.MockForms.Init();
        }

        [Test]
        public void CartDetailPage_Constructor_Should_Pass()
        {
            //Arrange
            Page = new CartPage();

            //Act

            //Reset

            //Assert
            Assert.IsNotNull(Page);
        }

        [Test]
        public void CartDetailPage_Constructor_With_CartImage_Is_True_Should_Pass()
        {
            //Arrange
            Page = new CartPage(true);

            //Act

            //Reset

            //Assert
            Assert.IsNotNull(Page);
        }

        
   



    }
}
