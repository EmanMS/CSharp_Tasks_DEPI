using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tak08
{
    internal interface ILogger
    {
        void Log(string message)
        {
            Console.WriteLine($"default: {message}");
        }
    }
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Console_Log: {message}");
        }
    }
    public class DefaultLog : ILogger
    {

    }
}
