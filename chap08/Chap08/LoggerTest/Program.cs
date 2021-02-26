using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerTest
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now} : {message}");
        }
    }

    interface IFormattableLogger : ILogger
    {
        void WriteLog(string format, params object[] args);
    }

    class ConsoleFormatLogger : IFormattableLogger
    {
        public void WriteLog(string format, params object[] args)
        {
            string message = string.Format(format, args);
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} / {message}");

            Console.WriteLine($"{DateTime.Now.ToLocalTime()} / {message}");
        }
    }
    public void WriteLog(string message)
    {
        Console.WriteLine($"{DateTime.Now.ToLocalTime()} : {message}");
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ConsoleLogger 테스트");
            ConsoleLogger logger = new ConsoleLogger();
            Console.WriteLine("로그메시지");

            IFormattableLogger logger2 = new ConsoleFormatLogger();
            logger2.WriteLog("{0} * {1} = {2}", 3, 4, 12);
        }
    }
}
