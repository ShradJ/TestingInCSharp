using Sparky;

namespace SparkyNUnitTest
{
    public class CalculatorNUnitTests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void AddNumbers_GetTwoIntegers_GetCorrectAddition()
        {
            var calc = new Calculator();
            var result = calc.AddNumber(3, 5);
            Assert.That(result,Is.EqualTo(8));
        }
    }
}