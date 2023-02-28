using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    [TestFixture]
    public class CustomerNUnitTest
    {
        [Test]
        public void CombineName_InputFirstAndLastName_ReturnFullName()
        {
            var customer = new Customer();
            string fullName = customer.GreetAndCombineNames("Ben", "Spark");
            Assert.That(fullName, Is.EqualTo("Hello Ben Spark"));
        }
    }
}
