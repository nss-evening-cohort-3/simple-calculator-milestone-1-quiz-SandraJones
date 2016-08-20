using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class DivisionTests
    {
        [TestMethod]
        public void TestDivideTwoNumbers()
        {
            //Arrange
            Division quotient = new Division();

            //Act
            quotient.DivideTwoNumbers(36, 6);

            //Assert
            Assert.AreEqual(6, quotient.DivideTwoNumbers(36, 6));
        }

        [TestMethod]
        public void TestInstanceOfModulo()
        {
            //Arrange
            Division quotient = new Division();

            //Assert
            Assert.IsNotNull(quotient);
        }
    }
}