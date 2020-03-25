using ExamplesForUnitTesting;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.UnitTestAssignments.Assignment3
{
    [TestClass]
    public class CalculatorMultiplyTests
    {
        private Calculator _calculator;

        [TestInitialize]
        public void Initialize()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void WhenMultiplyingFiveByFiveThenTheResultShouldBeTwentyFive()
        {
            _calculator.Multiply(5, 5).Should().Be(25);
        }
    }
}
