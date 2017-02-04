using Microsoft.VisualStudio.TestTools.UnitTesting;
using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {
        // Arrange
        double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };

        [TestMethod()]
        public void SumTest()
        {
            // Arrange
            double expected = 25.6;
            // Act
            double actual = ArrayCalcs.Sum(array);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AverageTest()
        {
            // Arrange
            double expected = 3.66;
            // Act
            double actual = ArrayCalcs.Average(array);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinTest()
        {
            // Arrange
            double expected = -4.5;
            // Act
            double actual = ArrayCalcs.Min(array);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxTest()
        {
            // Arrange
            double expected = 12.0;
            // Act
            double actual = ArrayCalcs.Max(array);
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}