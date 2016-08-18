using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class RegexTests
    {
        [TestMethod]
        public void TestInstanceOfRegex()
        {
            Regex parser = new SimpleCalculator.Regex();
            Assert.IsNotNull(parser);
        }

        [TestMethod]
        public void TestParsing()
        {
            //Arrange - instantiate what is needed
            Regex parser = new Regex();
            //Act - interact with the parser object
            parser.ParseInput("1 + 3");
            //Assert or test here
            Assert.AreEqual(1, parser.Term1);
            Assert.AreEqual(3, parser.Term2);
            Assert.AreEqual('+', parser.Operator);
             
        }
    }
}
