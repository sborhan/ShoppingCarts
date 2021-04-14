using System.Threading.Tasks;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using NUnit.Framework;

using ShoppingCarts.Controls;


namespace UnitTest.Controls
{
    [TestFixture]
    class ExtendedListViewTests
    {
        ExtendedListView control;

        [SetUp]
        public void Setup()
        {
        }

       // [Test]
        public void ExtendedListView_Constructor_Should_Pass()
        {
            //Arrange
            control = new ExtendedListView(ListViewCachingStrategy.RecycleElementAndDataTemplate);

            //Act

            //Reset

            //Assert
            Assert.IsNotNull(control);
        }

    }
}
