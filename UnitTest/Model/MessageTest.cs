using NUnit.Framework;
using ShoppingCarts.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace UnitTest.Model
{
    class MessageTest
    {
        Message control;
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Message_Constructor_Should_Pass()
        {
            //Arrange
            control = new Message();

            //Act

            //Reset

            //Assert
            Assert.IsNotNull(control);
        }

        [Test]
        public void MasterPageItem_With_valid_Text_Get_Should_Pass()
        {
            //Arrange
            var control = new Message();
            control.Text = "Sam";

            //Act
            var reuslt = control.Text;

            //Reset

            //Assert
            Assert.AreEqual("Sam", reuslt);
        }

        [Test]
        public void MasterPageItem_With_valid_User_Get_Should_Pass()
        {
            //Arrange
            var control = new Message();
            control.User = "Sam";

            //Act
            var reuslt = control.User;

            //Reset

            //Assert
            Assert.AreEqual("Sam", reuslt);
        }
    }
}

