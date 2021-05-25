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

        [Test]
        public void ItemModelTests_Get_Image_Should_Ppass()
        {
            //Arrange
            var control = new Item();
            control.Image = "SamImage";

            //Act
            var reuslt = control.Image;

            //Reset

            //Assert
            Assert.AreEqual("SamImage", reuslt);
        }

        [Test]
        public void ItemModelTests_Get_Status_Should_Ppass()
        {
            //Arrange
            var control = new Item();
            control.Status = true;

            //Act
            var reuslt = control.Status;

            //Reset

            //Assert
            Assert.AreEqual(true, reuslt);
        }

        [Test]
        public void ItemModelTests_Get_ButtonText_Should_Ppass()
        {
            //Arrange
            var control = new Item();
            control.ButtonText = "SamButtonText";

            //Act
            var reuslt = control.ButtonText;

            //Reset

            //Assert
            Assert.AreEqual("SamButtonText", reuslt);
        }

        [Test]
        public void ItemModelTests_Get_Index_Should_Ppass()
        {
            //Arrange
            var control = new Item();
            control.Index = 123;

            //Act
            var reuslt = control.Index;

            //Reset

            //Assert
            Assert.AreEqual(123, reuslt);
        }

        [Test]
        public void ItemModelTests_Get_Description_Should_Ppass()
        {
            //Arrange
            var control = new Item();
            control.Description = "SamDescription";

            //Act
            var reuslt = control.Description;

            //Reset

            //Assert
            Assert.AreEqual("SamDescription", reuslt);
        }

        [Test]
        public void ItemModelTests_Get_ShortDescription_Should_Ppass()
        {
            //Arrange
            var control = new Item();
            control.ShortDescription = "SamShortDescription";

            //Act
            var reuslt = control.ShortDescription;

            //Reset

            //Assert
            Assert.AreEqual("SamShortDescription", reuslt);
        }
    }
}

