using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class SubtractionTests
    {
       
        [TestMethod]
        public void TestSubtractTwoNumbers()
        {
            //Arrange
            Subtraction takeFrom = new Subtraction();

            //Act
            takeFrom.SubtractTwoNumbers(16, 9);

            //Assert
            Assert.AreEqual(7, takeFrom.SubtractTwoNumbers(16, 9));
        }

        [TestMethod]
        public void TestInstanceOfSubtraction()
        {
            //Arrange
            Subtraction takeFrom = new Subtraction();

            //Assert
            Assert.IsNotNull(takeFrom);
        }
    }
}
