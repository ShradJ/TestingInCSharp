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
        [Test]
        public void IsOddNumber_GetEvenNumberr_ReturnFalse()
        {
            var calc = new Calculator();
            var isOdd = calc.IsOddNumber(6);
            Assert.That(isOdd, Is.False);
        }
        [Test]
        [TestCase(11)]
        [TestCase(12)]
        public void IsOddNumber_GetOddNumberr_ReturnTrue(int a)
        {
            var calc = new Calculator();
            var isOdd = calc.IsOddNumber(a);
            Assert.That(isOdd, Is.True);
        }

        [Test]
        [TestCase(13, ExpectedResult = true)]
        [TestCase(12, ExpectedResult = false)]
        public bool IsOddNumber_GetOddNumber_ReturnTrueIfOdd(int a)
        {
            var calc = new Calculator();
            return  calc.IsOddNumber(a);
            //Assert.That(isOdd, Is.True);
        }

    }
}