using NUnit.Framework;
using ShoppingCarts.Controls;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest.Controls
{
    class ExtendedEditorControlTests
    {
        ExtendedEditorControl control;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TeExtendedEditorControl_Constructor_Should_Pass()
        {
            //Arrange
            control = new ExtendedEditorControl();

            //Act

            //Reset

            //Assert
            Assert.IsNotNull(control);
        }

    }
}
