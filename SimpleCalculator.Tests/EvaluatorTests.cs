using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class EvaluatorTests
    {
        [TestMethod]
        public void TestInstanceOfEvaluator()
        {
            Evaluator eval = new Evaluator();
            Assert.IsNotNull(true);
        }
    }
}
