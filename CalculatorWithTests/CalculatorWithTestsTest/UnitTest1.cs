using CalculatorWithTests;
using NUnit.Framework;

namespace CalculatorWithTestsTest
{
    public class Tests
    {
        [TestCase(10, 2, 12)]
        [TestCase(-14, 8, -6)]
        [TestCase(0, 3, 3)]
        [TestCase(1, 1, 2)]
        public void AddTest(double firstArg, double secondArg, double expectedResult)
        {
            double actualResult = Calculator.Add(firstArg, secondArg);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(10, 2, 8)]
        [TestCase(-14, 8, -22)]
        [TestCase(0, 3, -3)]
        [TestCase(1, 1, 0)]
        [TestCase(0, 0, 0)]
        public void SubtractTest(double firstArg, double secondArg, double expectedResult)
        {
            double actualResult = Calculator.Subtract(firstArg, secondArg);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(10, 2, 20)]
        [TestCase(-14, 8, -112)]
        [TestCase(0, 3, 0)]
        [TestCase(1, 1, 1)]
        [TestCase(0, 0, 0)]
        public void MultiplyTest(double firstArg, double secondArg, double expectedResult)
        {
            double actualResult = Calculator.Multiply(firstArg, secondArg);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(10, 2, 5)]
        [TestCase(-14, 8, -1.75)]
        [TestCase(0, 3, 0)]
        [TestCase(6, 6, 1)]
        [TestCase(11, 1, 11)]
        [TestCase(10, 0, 0)]
        public void DivideTest(double firstArg, double secondArg, double expectedResult)
        {
            double actualResult = Calculator.Divide(firstArg, secondArg);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(10, 2, 0)]
        [TestCase(-10, 3, -1)]
        [TestCase(0, 3, 0)]
        [TestCase(1, 1, 0)]
        [TestCase(10, 0, 0)]
        [TestCase(11, 1, 0)]
        public void RestOfDivideTest(double firstArg, double secondArg, double expectedResult)
        {
            double actualResult = Calculator.RestOfDivide(firstArg, secondArg);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0, 0)]
        [TestCase(-3, 0)]
        [TestCase(1, 1)]
        [TestCase(12, 479001600)]
        public void FactorialTest(double firstArg, double expectedResult)
        {
            double actualResult = Calculator.Factorial(firstArg);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0, 0)]
        [TestCase(-9, 0)]
        [TestCase(1, 1)]
        [TestCase(144, 12)]
        public void SqrtTest(double firstArg, double expectedResult)
        {
            double actualResult = Calculator.Sqrt(firstArg);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(2, 2, 4)]
        [TestCase(-2, 3, -8)]
        [TestCase(0, 3, 0)]
        [TestCase(1, 5, 1)]
        [TestCase(2, -4, 0)]
        [TestCase(11, 0, 1)]
        public void PowerTest(double firstArg, double secondArg, double expectedResult)
        {
            double actualResult = Calculator.Power(firstArg, secondArg);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
