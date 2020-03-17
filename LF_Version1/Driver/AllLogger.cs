using Logger253;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * BEFORE using inheritance in FileLogger
 * 
namespace Driver
{
    class AllLogger
    {
        //instead of writing FileLogger.LogToFile(".//log.txt", "Program Started!");
        //by added the parameter fileName and msg
        //we can write FileLogger.LogToFile(fileName, msg);
        public static void Log(string fileName, string msg)
        {
            ConsoleLogger.Log(msg);
            FileLogger.LogToFile(fileName, msg);
        }
    }
}
*/

namespace Driver
{
    class AllLogger
    {
        public static void Log(string fileName, string msg)
        {
            //NEW INSTANCE
            var console_Logger = new ConsoleLogger();
            //now we can log
            console_Logger.Log(msg);

            //we create a new instance and pass it the fileName ONLY ONCE
            var file_Logger = new FileLogger(fileName);
            //we can log as many times as we want, and we still don't have to pass the fileName again
            file_Logger.Log(msg);
            file_Logger.Log(msg);
            file_Logger.Log(msg);
        }
    }
}