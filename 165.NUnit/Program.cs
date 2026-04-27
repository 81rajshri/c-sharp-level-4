//Unit Testing using NUnit

using NUnit.Framework;

namespace DemoTest
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_Test()
        {
            Calculator calc = new Calculator();
            int result = calc.Add(2, 3);

            Assert.AreEqual(5, result);
        }
    }
}