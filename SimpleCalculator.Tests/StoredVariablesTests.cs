using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class StoredVariablesTests
    {
        
        [TestMethod]
        public void TestInstanceOfStoredVariables()
        {
            StoredVariables instanceOne = new StoredVariables();
            Assert.IsNotNull(instanceOne);
        }
    }
}
