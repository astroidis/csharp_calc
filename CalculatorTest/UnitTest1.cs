using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        private Calculator.Calculator calc = new Calculator.Calculator();

        [TestMethod]
        public void TestAdd()
        {
            double expected = 5;
            double result = calc.add(2, 3);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSub()
        {
            double expected = 3;
            double result = calc.sub(10, 7);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMul()
        {
            double expected = 10;
            double result = calc.mul(5, 2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestDiv()
        {
            double expected = 10;
            double? result = calc.div(20, 2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestRem()
        {
            int expected = 3;
            int? result = calc.rem(10, 7);

            Assert.AreEqual(expected, result);
        }
    }
}
