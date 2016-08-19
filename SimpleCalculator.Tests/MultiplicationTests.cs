using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class MultiplicationTests
    {
            [TestMethod]
            public void TestMultiplyTwoNumbers()
            {
                //Arrange
                Multiplication timesOther = new Multiplication();

                //Act
                timesOther.MultiplyTwoNumbers(3, 5);

                //Assert
                Assert.AreEqual(15, timesOther.MultiplyTwoNumbers(3, 5));
            }

            [TestMethod]
            public void TestInstanceOfSubtraction()
            {
                //Arrange
                Multiplication timesOther = new Multiplication();

                //Assert
                Assert.IsNotNull(timesOther);
            }
     }
}
