using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ConstantsTests
    {
        [TestMethod]
        public void TestInstanceOfConstant()
        {
            Constants _constant = new Constants();
            Assert.IsNotNull(_constant);
        }
    }
};
