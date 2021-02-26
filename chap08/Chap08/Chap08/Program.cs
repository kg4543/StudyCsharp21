using System;

namespace Chap08
{

    class Program
    {
        interface ILogger
        {
            void WriteLog(string msg);
        }

        class ConsoleLogger : ILogger
        {
            public void WriteLog(string msg)
            {
                Console.WriteLine($"{new DateTime().ToShortDateString()}log: {msg}");
            }
        }

        class CustomLogger : ILogger
        {
            public void WriteLog(string msg)
            {
                Console.WriteLine($"{msg} \a");
            }
        }
        class ClimateLogger
        {
            private ILogger logger;
            public ClimateLogger(ILogger logger)
            {
                this.logger = logger;
            }

            public void start()
            {
                while (true)
                {
                    Console.Write("온도 입력 : ");
                    string temp = Console.ReadLine();
                    if (string.IsNullOrEmpty(temp)) break;

                    logger.WriteLog($"현재 온도 : {temp}");
                }
            }
        }

        static void Main(string[] args)
        {
            ConsoleLogger logger = new ConsoleLogger();
            logger.WriteLog("로그출력!"); //직접제어

            ClimateLogger clogger = new ClimateLogger(new ConsoleLogger());
            clogger.start(); //IoC 제어의 역전

            ClimateLogger culogger = new ClimateLogger(new CustomLogger());
            culogger.start(); //IoC 제어의 역전
        }
    }
}
