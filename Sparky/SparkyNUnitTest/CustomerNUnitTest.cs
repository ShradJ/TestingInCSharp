using Sparky;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class CustomerNUnitTest
    {
        private Customer customer;
        [SetUp]
       public void Setup()
        {
            customer = new();
        }
        [Test]
        public void CombineName_InputFirstAndLastName_ReturnFullName()
        {
           // var customer = new Customer();
            string fullName = customer.GreetAndCombineNames("Ben", "Spark");
            Assert.That(fullName, Is.EqualTo("Hello Ben Spark"));
        }

        [Test]
        public void GreetMessage_NotGreeted_ReturnNull() 
        {
           // var customer = new Customer();
            Assert.IsNull(customer.GreetMessage);
        }
    }
}
