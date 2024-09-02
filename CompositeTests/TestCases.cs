/******************************************************************************
 * Filename    = TestCases.cs
 *
 * Author      = Sunil Varma Tenali
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = Unit Tests
 *
 * Description = Unit Tests for Composite Design Pattern
 *****************************************************************************/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompositeDesignPattern;
using System;

namespace CompositeTests
{
    [TestClass]
    public class TestCases
    {
        [TestMethod]
        public void TestSingleGiftPrice()
        {
            // Arrange
            var singleGift = new SingleGift( "Toy" , 20.00m );

            // Act
            decimal totalPrice = singleGift.CalculateTotalPrice();

            // Assert
            Assert.AreEqual( 20.00m , totalPrice , "The price of a single gift should match its price." );
        }

        [TestMethod]
        public void TestCompositeGiftTotalPrice()
        {
            // Arrange
            var compositeGift = new CompositeGift( "Gift Basket" , 0.00m );
            var gift1 = new SingleGift( "Toy" , 20.00m );
            var gift2 = new SingleGift( "Book" , 15.00m );
            compositeGift.Add( gift1 );
            compositeGift.Add( gift2 );

            // Act
            decimal totalPrice = compositeGift.CalculateTotalPrice();

            // Assert
            Assert.AreEqual( 35.00m , totalPrice , "The total price of the composite gift should be the sum of its children's prices." );
        }

        [TestMethod]
        public void TestAddGiftToComposite()
        {
            // Arrange
            var compositeGift = new CompositeGift( "Gift Basket" , 0.00m );
            var singleGift = new SingleGift( "Toy" , 20.00m );

            // Act
            compositeGift.Add( singleGift );
            decimal totalPrice = compositeGift.CalculateTotalPrice();

            // Assert
            Assert.AreEqual( 20.00m , totalPrice , "The total price after adding a gift should match the price of the added gift." );
        }

        [TestMethod]
        public void TestRemoveGiftFromComposite()
        {
            // Arrange
            var compositeGift = new CompositeGift( "Gift Basket" , 0.00m );
            var gift1 = new SingleGift( "Toy" , 20.00m );
            var gift2 = new SingleGift( "Book" , 15.00m );
            compositeGift.Add( gift1 );
            compositeGift.Add( gift2 );

            // Act
            compositeGift.Remove( gift1 );
            decimal totalPrice = compositeGift.CalculateTotalPrice();

            // Assert
            Assert.AreEqual( 15.00m , totalPrice , "The total price after removing a gift should be the sum of the remaining gifts' prices." );
        }
    }
}
