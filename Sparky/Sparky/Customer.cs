using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    public class Customer
    {
        public string GreetMessage { get; set; }
        public int Discount { get; set; } = 15;
        public bool IsPlatinum { get; set; } = false; 
        public string GreetAndCombineNames(string firstName, string secondName)
        {
            GreetMessage = $"Hello {firstName} {secondName}"; 
            Discount = 20 ;
            return GreetMessage ;
        }
    }
}
