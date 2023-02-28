using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    public interface ILogbook
    {
        void Message(string message);
    }
    public class LogBook : ILogbook
    {
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class LogBook1 : ILogbook
    {
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
