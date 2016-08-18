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
        public void TestParsing1()
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

        [TestMethod]
        public void TestParsing2()
        {
            //Arrange - instantiate what is needed
            Regex parser = new Regex();

            //Act - interact with the parser object
            parser.ParseInput("31 - 9");

            //Assert or test here
            Assert.AreEqual(31, parser.Term1);
            Assert.AreEqual(9, parser.Term2);
            Assert.AreEqual('-', parser.Operator);
        }
        [TestMethod]
        public void TestParsing3()
        {
            //Arrange - instantiate what is needed
            Regex parser = new Regex();

            //Act - interact with the parser object
            parser.ParseInput("23 % 3");

            //Assert or test here
            Assert.AreEqual(23, parser.Term1);
            Assert.AreEqual(3, parser.Term2);
            Assert.AreEqual('%', parser.Operator);
        }
        [TestMethod]
        public void TestParsing4()
        {
            //Arrange - instantiate what is needed
            Regex parser = new Regex();

            //Act - interact with the parser object
            parser.ParseInput("-11 + 39");

            //Assert or test here
            Assert.AreEqual(-11, parser.Term1);
            Assert.AreEqual(39, parser.Term2);
            Assert.AreEqual('+', parser.Operator);
        }
        [TestMethod]
        public void TestParsing5()
        {
            //Arrange - instantiate what is needed
            Regex parser = new Regex();

            //Act - interact with the parser object
            parser.ParseInput("12 / 3");

            //Assert or test here
            Assert.AreEqual(12, parser.Term1);
            Assert.AreEqual(3, parser.Term2);
            Assert.AreEqual('/', parser.Operator);
        }
        [TestMethod]
        public void TestParsing6()
        {
            //Arrange - instantiate what is needed
            Regex parser = new Regex();

            //Act - interact with the parser object
            parser.ParseInput("10 * 3");

            //Assert or test here
            Assert.AreEqual(10, parser.Term1);
            Assert.AreEqual(3, parser.Term2);
            Assert.AreEqual('*', parser.Operator);
        }
        [TestMethod]
        public void TestParsing7()
        {
            //Arrange - instantiate what is needed
            Regex parser = new Regex();

            //Act - interact with the parser object
            parser.ParseInput("-10 - -5");

            //Assert or test here
            Assert.AreEqual(-10, parser.Term1);
            Assert.AreEqual(-5, parser.Term2);
            Assert.AreEqual('-', parser.Operator);
        }
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestBadInput1()
        {
            Regex parser = new Regex();
            parser.ParseInput("qoqiergjaorgj");
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestBadInput2()
        {
            Regex parser = new Regex();
            parser.ParseInput("10a + b");
        }
    }
}
