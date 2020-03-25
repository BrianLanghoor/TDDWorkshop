using System;
using System.Collections.Generic;
using System.Text;
using ExamplesForUnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.UnitTestAssignments.Assignment1
{
    [TestClass]
    public class CalculatorAddTests
    {
        [TestMethod]
        public void WhenAddingTheNumberTwoAndFiveTheResultShouldBeSeven()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Add(2, 5);

            //Assert
            Assert.AreEqual(7, result);
        }
    }
}
