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
            Expressions myFirstExpression = new Expressions();
            Expressions mySecondExpression = new Expressions();
            Assert.IsNotNull(myFirstExpression);
            Assert.IsNotNull(mySecondExpression);
        }
    }
}
