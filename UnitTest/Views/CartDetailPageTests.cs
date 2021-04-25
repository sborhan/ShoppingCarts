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
    class CartDetailPageTests
    {
        CartDetailPage detailPage;

        [SetUp]
        public void Setup()
        {
            Xamarin.Forms.Mocks.MockForms.Init();
        }

        [Test]
        public void CartDetailPage_Constructor_Should_Pass()
        {
            //Arrange
            detailPage = new CartDetailPage();

            //Act

            //Reset

            //Assert
            Assert.IsNotNull(detailPage);
        }

        [Test]
        public void CartDetailPage_OnItemSelected_with_New_ListView_sender_Should_Pass()
        {
            //Arrange
            detailPage = new CartDetailPage();

            //Act
            detailPage.OnItemSelected(new ListView(), null);

            //Reset

            //Assert
            Assert.Pass();
        }

    }
}
