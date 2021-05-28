using NUnit.Framework;
using ShoppingCarts.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace UnitTest.Model
{
    class ProductDetailTests
    {
        ProductDetail control;
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void ProductDetail_Constructor_Should_Pass()
        {
            //Arrange
            control = new ProductDetail();

            //Act

            //Reset

            //Assert
            Assert.IsNotNull(control);
        }

        [Test]
        public void Product_With_valid_ProducName_Get_Should_Pass()
        {
            //Arrange
            var control = new Product();
            control.ProductName = "Sam";

            //Act
            var reuslt = control.ProductName;

            //Reset

            //Assert
            Assert.AreEqual("Sam", reuslt);
        }

        [Test]
        public void Product_Constructor_Should_Pass()
        {
            //Arrange
            var control = new Product();

            //Act

            //Reset

            //Assert
            Assert.IsNotNull(control);
        }

        [Test]
        public void ProductDetail_With_valid_Name_Get_Should_Pass()
        {
            //Arrange
            var control = new ProductDetail();
            control.Name = "Sam";

            //Act
            var reuslt = control.Name;

            //Reset

            //Assert
            Assert.AreEqual("Sam", reuslt);
        }

        [Test]
        public void ProductDetail_With_valid_ImageUrl_Get_Should_Pass()
        {
            //Arrange
            var control = new ProductDetail();
            control.ImageUrl = "Sam";

            //Act
            var reuslt = control.ImageUrl;

            //Reset

            //Assert
            Assert.AreEqual("Sam", reuslt);
        }

        [Test]
        public void ProductDetail_With_valid_ShortDescription_Get_Should_Pass()
        {
            //Arrange
            var control = new ProductDetail();
            control.ShortDescription = "Sam";

            //Act
            var reuslt = control.ShortDescription;

            //Reset

            //Assert
            Assert.AreEqual("Sam", reuslt);
        }

        [Test]
        public void ProductDetail_With_valid_Description_Get_Should_Pass()
        {
            //Arrange
            var control = new ProductDetail();
            control.Description = "Sam";

            //Act
            var reuslt = control.Description;

            //Reset

            //Assert
            Assert.AreEqual("Sam", reuslt);
        }

        [Test]
        public void ProductDetail_With_valid_NameSort_Get_Should_Pass()
        {
            //Arrange
            var control = new ProductDetail();
            control.Name = "Sam";

            //Act
            var reuslt = control.NameSort;

            //Reset

            //Assert
            Assert.AreEqual("S", reuslt);
        }

        [Test]
        public void ProductDetail_With_Empty_Name_Should_Pass()
        {
            //Arrange
            var control = new ProductDetail();
            control.Name = "";

            //Act
            var reuslt = control.NameSort;

            //Reset

            //Assert
            Assert.AreEqual("?", reuslt);
        }

        [Test]
        public void ProductDetail_With_Null_Name_Should_Pass()
        {
            //Arrange
            var control = new ProductDetail();
            control.Name = null;

            //Act
            var reuslt = control.NameSort;

            //Reset

            //Assert
            Assert.AreEqual("?", reuslt);
        }

        [Test]
        public void Product_With_valid_ProducID_Get_Should_Pass()
        {
            //Arrange
            var control = new Product();
            control.ProductId = Guid.Empty;

            //Act
            var reuslt = control.ProductId;

            //Reset

            //Assert
            Assert.AreEqual(Guid.Empty, reuslt);
        }

        [Test]
        public void Product_With_Valid_ProducName_Get_Should_Pass()
        {
            //Arrange
            var control = new Product();
            control.ProductName = "Sam";

            //Act
            var reuslt = control.ProductName;

            //Reset

            //Assert
            Assert.AreEqual("Sam", reuslt);
        }

        [Test]
        public void Product_With_valid_ProductImageUrl_Get_Should_Pass()
        {
            //Arrange
            var control = new Product();
            control.ProductImageUrl = "SamUrl";

            //Act
            var reuslt = control.ProductImageUrl;

            //Reset

            //Assert
            Assert.AreEqual("SamUrl", reuslt);
        }

        [Test]
        public void Product_With_valid_ProductShortDescription_Get_Should_Pass()
        {
            //Arrange
            var control = new Product();
            control.ProductShortDescription = "Sam";

            //Act
            var reuslt = control.ProductShortDescription;

            //Reset

            //Assert
            Assert.AreEqual("Sam", reuslt);
        }

        [Test]
        public void Product_With_valid_ProductDescription_Get_Should_Pass()
        {
            //Arrange
            var control = new Product();
            control.ProductDescription = "Sam";

            //Act
            var reuslt = control.ProductDescription;

            //Reset

            //Assert
            Assert.AreEqual("Sam", reuslt);
        }

        [Test]
        public void Product_With_valid_ProductStatus_Get_Should_Pass()
        {
            //Arrange
            var control = new Product();
            control.ProductStatus = true;

            //Act
            var reuslt = control.ProductStatus;

            //Reset

            //Assert
            Assert.AreEqual(true, reuslt);
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
        public void ItemModelTests_With_Valid_Name_Get_NameSort_Should_Pass()
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

