using System;
using LoggerCore;

/*
 * BEFORE referencing LoggerCore in the Dependencies
 * 
namespace Logger253
{
    public class ConsoleLogger
    {

        public static void Log(string msg)
        {
            Console.WriteLine($"{DateTime.Now} {msg}");
        }

    }
}
*/

namespace Logger253
{
    public class ConsoleLogger : BaseLogger
    {
        //now we need to provide a constructor
        public ConsoleLogger(LogOutput logOutput) : base(logOutput)
        {

        }

        protected override void SubClassLog(string msg)
        {
            if(logOutput == LogOutput.OutputToBoth || logOutput == LogOutput.OutputToConsole)
            {
                Console.WriteLine(msg);
            }
        }
        
    }
}
