using NUnit.Framework;
using ShoppingCarts.Controls;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

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
        public void ExtendedEditorControl_Constructor_Should_Pass()
        {
            //Arrange
            control = new ExtendedEditorControl();
            
            //Act

            //Reset

            //Assert
            Assert.IsNotNull(control);
        }

        [Test]
        public void ExtendedEditorControl_Static_Field_PlaceholderProperty_Should_Initilized_And_Pass()
        {
            //Arrange

            //Act

            //Reset

            //Assert
            Assert.IsNotNull(ExtendedEditorControl.PlaceholderProperty);
        }

        [Test]
        public void ExtendedEditorControl_Static_Field_PlaceholderColorProperty_Should_Initilized_And_Pass()
        {
            //Arrange

            //Act

            //Reset

            //Assert
            Assert.IsNotNull(ExtendedEditorControl.PlaceholderColorProperty);
        }

        [Test]
        public void ExtendedEditorControl_Static_Field_HasRoundedCornerProperty_should_Initilized_And_Pass()
        {
            //Arrange

            //Act

            //Reset

            //Assert
            Assert.IsNotNull(ExtendedEditorControl.HasRoundedCornerProperty);
        }

        [Test]
        public void ExtendedEditorControl_Static_Field_IsExpandableProperty_Should_Initilized_And_Pass()
        {
            //Arrange

            //Act

            //Reset

            //Assert
            Assert.IsNotNull(ExtendedEditorControl.IsExpandableProperty);
        }

        [Test]
        public void ExtendedEditorControl_IsExpandable_Get_With_True_ExpandableProperty_Should_Return_True()
        {
            //Arrange          
            control = new ExtendedEditorControl();
            control.SetValue(ExtendedEditorControl.IsExpandableProperty, true);

            //Act
            var Result = control.IsExpandable;

            //Reset

            //Assert
            Assert.AreEqual(true,Result);
        }

        [Test]
        public void ExtendedEditorControl_IsExpandable_Set_To_True_ExpandableProperty_Should_Return_True()
        {
            //Arrange          
            control = new ExtendedEditorControl();
            control.SetValue(ExtendedEditorControl.IsExpandableProperty, false);

            //Act
            control.IsExpandable = true;
            var Result = control.IsExpandable;

            //Reset

            //Assert
            Assert.AreEqual(true, Result);
        }

        [Test]
        public void ExtendedEditorControl_HasRoundedCorner_Get_With_True_HasRoundedCornerProperty_Should_Return_True()
        {
            //Arrange          
            control = new ExtendedEditorControl();
            control.SetValue(ExtendedEditorControl.HasRoundedCornerProperty, true);

            //Act
            var Result = control.HasRoundedCorner;

            //Reset

            //Assert
            Assert.AreEqual(true, Result);
        }

        [Test]
        public void ExtendedEditorControl_HasRoundedCorner_Set_To_HasRoundedCornerProperty_Should_Return_True()
        {
            //Arrange          
            control = new ExtendedEditorControl();
            control.SetValue(ExtendedEditorControl.HasRoundedCornerProperty, false);

            //Act
            control.HasRoundedCorner = true;
            var Result = control.HasRoundedCorner;

            //Reset

            //Assert
            Assert.AreEqual(true, Result);
        }

        [Test]
        public void ExtendedEditorControl_Placeholder_Get_With_Valid_PlaceholderProperty_Should_Pass()
        {
            //Arrange          
            control = new ExtendedEditorControl();
            control.SetValue(ExtendedEditorControl.PlaceholderProperty, "test");

            //Act
            var Result = control.Placeholder;

            //Reset

            //Assert
            Assert.AreEqual("test", Result);
        }

        [Test]
        public void ExtendedEditorControl_Placeholder_Set_To_Valid_PlaceholderProperty_Should_Pass()
        {
            //Arrange          
            control = new ExtendedEditorControl();

            //Act
            control.Placeholder = "test";
            var Result = control.Placeholder;

            //Reset

            //Assert
            Assert.AreEqual("test", Result);
        }

        [Test]
        public void ExtendedEditorControl_PlaceholderColor_Get_With_Valid_PlaceholderColorProperty_Should_Pass()
        {
            //Arrange          
            control = new ExtendedEditorControl();
            control.SetValue(ExtendedEditorControl.PlaceholderColorProperty, Color.Red);

            //Act
            var Result = control.PlaceholderColor;

            //Reset

            //Assert
            Assert.AreEqual(Color.Red, Result);
        }

        [Test]
        public void ExtendedEditorControl_PlaceholderColor_Set_To_Valid_PlaceholderColor_Should_Pass()
        {
            //Arrange          
            control = new ExtendedEditorControl();

            //Act
            control.PlaceholderColor = Color.Red;
            var Result = control.PlaceholderColor;

            //Reset

            //Assert
            Assert.AreEqual(Color.Red, Result);
        }

    }
}
