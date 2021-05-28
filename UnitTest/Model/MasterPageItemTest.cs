using NUnit.Framework;
using ShoppingCarts.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace UnitTest.Model
{
    class MasterPageItemTest
    {
        MasterPageItem control;
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void MasterPageItem_Constructor_Should_Pass()
        {
            //Arrange
            control = new MasterPageItem();

            //Act

            //Reset

            //Assert
            Assert.IsNotNull(control);
        }

        [Test]
        public void MasterPageItem_With_valid_Title_Get_Should_Pass()
        {
            //Arrange
            var control = new MasterPageItem();
            control.Title = "Sam";

            //Act
            var reuslt = control.Title;

            //Reset

            //Assert
            Assert.AreEqual("Sam", reuslt);
        }

        [Test]
        public void MasterPageItem_With_valid_TargetType_Get_Should_Pass()
        {
            //Arrange
            var control = new MasterPageItem();
            control.TargetType = null;

            //Act
            var reuslt = control.TargetType;

            //Reset

            //Assert
            Assert.AreEqual(null, reuslt);
        }

        [Test]
        public void MasterPageItem_With_valid_ImageName_Get_Should_Pass()
        {
            //Arrange
            var control = new MasterPageItem();
            control.ImageName = "Sam";

            //Act
            var reuslt = control.ImageName;

            //Reset

            //Assert
            Assert.AreEqual("Sam", reuslt);
        }

    }
}

