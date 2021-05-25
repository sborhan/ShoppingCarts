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

        [Test]
        public void ItemModelTests_With_valid_Name_Get_NameSort_Should_Pass()
        {
            //Arrange
            var control = new Item();
            control.Name = "Sam";

            //Act
            var reuslt = control.NameSort;

            //Reset

            //Assert
            Assert.AreEqual("S", reuslt);
        }

        [Test]
        public void ItemModelTests_With_Invalid_WhiteSpace_Name_Get_NameSort_Should_Return_QuestionMark()
        {
            //Arrange
            var control = new Item();
            control.Name = " ";

            //Act
            var reuslt = control.NameSort;

            //Reset

            //Assert
            Assert.AreEqual("?", reuslt);
        }


        [Test]
        public void ItemModelTests_With_Invalid_Null_Name_Get_NameSort_Should_Return_QuestionMark()
        {
            //Arrange
            var control = new Item();
            control.Name = null;

            //Act
            var reuslt = control.NameSort;

            //Reset

            //Assert
            Assert.AreEqual("?", reuslt);
        }


    }

}