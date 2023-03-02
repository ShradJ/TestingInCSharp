using Moq;

using NUnit.Framework;

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

        //simple implementation of IsAny-- it will pass for any int withdrawal even if it is greater than deposit
        [Test]
        public void BankWithdraw_Withdraw100With200Balance_ReturnsTrueRegardlessOfWithDrwalaAmount()
        {
            var logMock = new Mock<ILogbook>();
            logMock.Setup(u=>u.LogToDb(It.IsAny<string>())).Returns(true);
            logMock.Setup(u=>u.LogBalanceAfterWithdrawal(It.IsAny<int>())).Returns(true);
            bankAccount = new(logMock.Object);
            bankAccount.Deposit(200);
            var result = bankAccount.WithDraw(500);
            Assert.IsTrue(result);
        }
        [Test]
        public void BankWithdraw_Withdraw100With200Balance_ReturnsTrue()
        {
            var logMock = new Mock<ILogbook>();
            logMock.Setup(u => u.LogToDb(It.IsAny<string>())).Returns(true);
            logMock.Setup(u => u.LogBalanceAfterWithdrawal(It.Is<int>(x=>x>0))).Returns(true);
            bankAccount = new(logMock.Object);
            bankAccount.Deposit(200);
            var result = bankAccount.WithDraw(100);
            Assert.IsTrue(result);
        }
        [Test]
        public void BankWithdraw_Withdraw300With200Balance_ReturnsFalse()
        {
            var logMock = new Mock<ILogbook>();
            logMock.Setup(u => u.LogToDb(It.IsAny<string>())).Returns(true);
            logMock.Setup(u => u.LogBalanceAfterWithdrawal(It.Is<int>(x=>x<0))).Returns(false);
            bankAccount = new(logMock.Object);
            bankAccount.Deposit(200);
            var result = bankAccount.WithDraw(100);
            Assert.IsFalse(result);
        }
        [Test]
        public void BankLogDummy_LogMockString_ReturnTrue()
        {
            var logMock = new Mock<ILogbook>();
            string desiredOutput = "hello";
            logMock.Setup(u => u.MessageWithReturnStr(It.IsAny<string>())).Returns((string str)=> str.ToLower()) ;
            Assert.That(logMock.Object.MessageWithReturnStr("Hello"), Is.EqualTo(desiredOutput));
        }
    }
}
