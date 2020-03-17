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
        public override void Log(string msg)
        {
            throw new NotImplementedException();
        }
    }
}

//now we go do the same to FileLogger --> making it INHERIT from BaseLogger