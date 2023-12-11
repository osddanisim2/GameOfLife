using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using laba5;

namespace UnitTestProject1
{
    [TestClass]
    public class SinSeriesCalculatorTests
    {
        [TestMethod]
        public void TestCalculateSinSeries()
        {
            SinSeriesCalculator sin = new SinSeriesCalculator(0.5, 1000);
            double x = 2.0;
            int n = 5;
            double expected = Math.Sin(x); // Assuming Math.Sin is correct for comparison

            double resultLoop = sin.CalculateSinSeries(x, n);

            Assert.AreEqual(expected, resultLoop, 0.0001); // Adjust delta as needed
        }

        [TestMethod]
        public void TestCalculateSinSeriesRecursive()
        {
            SinSeriesCalculator sin = new SinSeriesCalculator(0.5, 1000);
            double x = 2.0;
            int n = 5;
            double expected = Math.Sin(x); // Assuming Math.Sin is correct for comparison

            double resultRecursive = sin.CalculateSinSeriesRecursive(x, n);

            Assert.AreEqual(expected, resultRecursive, 0.0001); // Adjust delta as needed
        }
    }
}
