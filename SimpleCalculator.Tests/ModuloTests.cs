using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ModuloTests
    {
        [TestMethod]
        public void TestModuloTwoNumbers()
        {
            //Arrange
            Modulo remainder = new Modulo();

            //Act
            remainder.ModuloTwoNumbers(22, 5);

            //Assert
            Assert.AreEqual(2, remainder.ModuloTwoNumbers(22, 5));
        }

        [TestMethod]
        public void TestInstanceOfModulo()
        {
            //Arrange
            Modulo remainder = new Modulo();

            //Assert
            Assert.IsNotNull(remainder);
        }
    }
}
