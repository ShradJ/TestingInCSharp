using Sparky;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class ProductNUnitTests
    { 
        [Test]
        public void GetProduct_PlatinumCustomer_ReturnPriceWith20Discount()
        {
            Product product = new Product() { Price = 50 };
            //since there is no dependency injection needed in product class, we will use a customer object
            // rather than a MOQ object. 
            var result = product.GetPrice(new Customer() { IsPlatinum=true });
            Assert.That(result, Is.EqualTo(40));
        }

    }
}
