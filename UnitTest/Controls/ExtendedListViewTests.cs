using System.Threading.Tasks;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using NUnit.Framework;

using ShoppingCarts.Controls;
using ShoppingCarts;

namespace UnitTest.Controls
{
    [TestFixture]
    class ExtendedListViewTests
    {
        ExtendedListView control;

        [SetUp]
        public void Setup()
        {
            Xamarin.Forms.Mocks.MockForms.Init();
        }

        [Test]
        public void ExtendedListView_Constructor_Should_Pass()
        {
            //Arrange
            //App app = new App();
            control = new ExtendedListView();

            //Act

            //Reset

            //Assert
            Assert.IsNotNull(control);
        }

    }
}
