using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionsTests
    {
        [TestMethod]
        public void InstancesOfExpressions()
        {
            Subtraction myFirstExpression = new Subtraction();
            Subtraction mySecondExpression = new Subtraction();
            Assert.IsNotNull(myFirstExpression);
            Assert.IsNotNull(mySecondExpression);
        }
    }
}
