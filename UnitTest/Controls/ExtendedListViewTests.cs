using System.Threading.Tasks;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using NUnit.Framework;

using ShoppingCarts.Controls;
using ShoppingCarts;
using System.Windows.Input;

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
            control = new ExtendedListView();

            //Act

            //Reset

            //Assert
            Assert.IsNotNull(control);
        }

        [Test]
        public void ExtendedListView_TappedCommand_Get_Should_Pass()
        {
            //Arrange
            control = new ExtendedListView();

            //Act
            var Result = control.TappedCommand;

            //Reset

            //Assert
            Assert.AreEqual(null, Result);
        }

        [Test]
        public void ExtendedListView_ItemAppearingCommand_Get_Should_Pass()
        {
            //Arrange
            control = new ExtendedListView();

            //Act
            control.ItemAppearingCommand = null;


            //Reset

            //Assert
            Assert.IsNull(control.TappedCommand);
        }

        [Test]
        public void ExtendedListView_ItemDisappearingCommand_Get_Should_Pass()
        {
            //Arrange
            control = new ExtendedListView();

            //Act
            control.ItemDisappearingCommand = null;


            //Reset

            //Assert
            Assert.IsNull(control.TappedCommand);
        }


    }
}
