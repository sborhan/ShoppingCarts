using NUnit.Framework;
using ShoppingCarts.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace UnitTest.Model
{
    class ItemModelTests
    {
        ItemModelTests control;
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void ItemModelTests_Constructor_Should_Pass()
        {
            //Arrange
            control = new ItemModelTests();

            //Act

            //Reset

            //Assert
            Assert.IsNotNull(control);
        }


    }

}