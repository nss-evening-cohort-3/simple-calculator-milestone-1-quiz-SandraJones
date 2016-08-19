using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class AdditionTests
    {
        [TestMethod]
        public void TestAdditionMethod1()
        {
            //Arrange
            Addition addTo = new Addition();

            //Act
            addTo.AddTwoNumbers(6, -8);

            //Assert
            Assert.AreEqual(-2, addTo.AddTwoNumbers(6, -8));
        }

        [TestMethod]
        public void TestInstanceOfAddition()
        {
            //Arrange
            Addition addTo = new Addition();

            //Assert
            Assert.IsNotNull(addTo);
        }
    }
}
