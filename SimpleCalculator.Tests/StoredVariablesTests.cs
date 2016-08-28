using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class StoredVariablesTests
    {
        
        [TestMethod]
        public void TestInstanceOfVariable()
        { 
            //Arrange
            StoredVariables instanceOne = new StoredVariables();
            //Assert
            Assert.IsNotNull(instanceOne);
        }
    }
}
