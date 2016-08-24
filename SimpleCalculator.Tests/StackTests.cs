using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void TestInstanceOfStack()
        {
            //Arrange
            Stack insertion = new Stack();

            //Assert
            Assert.IsNotNull(insertion);
        }

    }
}

