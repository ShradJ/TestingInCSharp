using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("SparkyNUnitTest")]
namespace Sparky
{
    internal class BankAccount
    {
        public readonly ILogbook _logbook;
        public int Balance { get; set; }
        public BankAccount(ILogbook logbook)
        {
            _logbook = logbook;
            Balance = 0;
        }

        public bool Deposit(int amount)
        {
            _logbook.Message("Deposit Invoked");
            Balance+=amount;
            return true;
        }
        public bool WithDraw(int amount) {
        if(amount > 0)
            {
                _logbook.LogToDb("Amount withdrwal : " + amount.ToString());
                Balance -= amount;
                return _logbook.LogBalanceAfterWithdrawal(Balance);
            }
        return _logbook.LogBalanceAfterWithdrawal(Balance);
        }
    }
}
