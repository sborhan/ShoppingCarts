using NUnit.Framework;
using ShoppingCarts.ViewModels;
using ShoppingCarts.Model;

using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace UnitTest.ViewModels
{
    class CartDetailPageViewModelTest
    {
        CartDetailPageViewModel control;

        [SetUp]
        public void Setup()
        {
            Xamarin.Forms.Mocks.MockForms.Init();

        }

        [Test]
        public void CartDetailPageViewModelTests_SetItems_Should_Pass()
        {
            //Arrange
            control = new CartDetailPageViewModel();
            List<Item> ItemList = new List<Item>();
            ItemList.Add(new Item() { Name = "Item"});
            //Act
            control.SetItems(ItemList);
            //Reset

            //Assert
            Assert.IsTrue(control.ItemsInCart);
        }
    }
}

