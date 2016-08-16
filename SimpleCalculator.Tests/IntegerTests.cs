using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class IntegerTests
    {
        [TestMethod]
        public void CreateAnInstanceOfInteger()
        {
            Integer myInt = new Integer();
            Assert.IsNotNull(myInt);
        }
    }
}
