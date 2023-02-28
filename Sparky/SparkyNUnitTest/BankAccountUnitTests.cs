using Moq;

using Sparky;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class BankAccountUnitTests
    {
        private BankAccount bankAccount;
        [SetUp] 
        public void Setup()
        {
           
        }
        
        [Test]
        public void BankDepositWithLobBookObject_Add100_ReturnTrue()
        {
            bankAccount = new(new LogBook());
            var result = bankAccount.Deposit(100);
            Assert.IsTrue(result);
            Assert.That(bankAccount.Balance, Is.EqualTo(100));
        }

        [Test]
        public void BankDepositWith_Add100_ReturnTrue()
        {
            var logMock = new Mock<ILogbook>();
            bankAccount = new(logMock.Object);

            var result = bankAccount.Deposit(100);
            Assert.IsTrue(result);
            Assert.That(bankAccount.Balance, Is.EqualTo(100));
        }
    }
}
