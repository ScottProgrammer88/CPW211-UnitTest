using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            // Use the DataRow values to test the Add method

            // Arrange
            double expected = num1 + num2;

            // Act
            double result = num1 + num2;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(2, -3)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            // Use a few pairs of values to test the Multiply method

            // Arrange
            double expected = num1 * num2;

            // Act
            double result = num1 * num2;

            // Assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void Divide_DenominatorZero_ThrowsArgumentException()
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"

            // Arrange
            double num1 = 5; // numerator
            double num2 = 0; // denominator

            // Act
            double result = num1 / num2;

            // Assert
            Assert.ThrowsException<ArgumentException>(() => num1 / num2);
        }

        // TODO: Test Divide method with two valid numbers
        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(2, -3)]
        public void Divide_TwoNumbers_ReturnsQuotient(double num1, double num2)
        {
            // Arrange
            double expected = num1 / num2;

            // Act
            double result = num1 / num2;

            // Assert
            Assert.AreEqual(expected, result);
        }

        // TODO: Test subtract method with two valid numbers
        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(2, -3)]
        public void Subtract_TwoNumbers_ReturnsDifference(double num1, double num2)
        {
            // Arrange
            double expected = num1 - num2;

            // Act
            double result = num1 - num2;

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}