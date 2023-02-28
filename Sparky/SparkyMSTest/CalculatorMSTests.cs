using Sparky;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkyMSTest
{
    [TestClass]
    public class CalculatorMSTests
    {
        [TestMethod] 
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrange
            Calculator calculator = new();
            //Act
            var result = calculator.AddNumber(3, 5);
            //Assert
            Assert.AreEqual(8, result);
        }
    }
}
