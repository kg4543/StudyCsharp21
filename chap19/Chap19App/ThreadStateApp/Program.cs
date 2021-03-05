using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadStateApp
{
    class Program
    {
        static void PrintState(ThreadState state)
        {
            Console.WriteLine($"{state, -16} : {(int)state}");
        }
        static void Main(string[] args)
        {
            PrintState(ThreadState.Running); //상태값 0
            PrintState(ThreadState.StopRequested);
            PrintState(ThreadState.Stopped);

            PrintState(ThreadState.SuspendRequested);
            PrintState(ThreadState.Suspended);

            PrintState(ThreadState.AbortRequested);
            PrintState(ThreadState.Aborted);

            PrintState(ThreadState.Unstarted);
            PrintState(ThreadState.WaitSleepJoin);
            
        }
    }
}
