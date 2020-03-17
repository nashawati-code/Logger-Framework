using Logger253;
using System.Threading;

namespace Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger.Log("Hello World!");
            FileLogger.LogToFile(".//log.txt", "Hello World!");

            /*
            ConsoleLogger.Log("Program Started!");
            FileLogger.LogToFile(".\\log.txt", "Program Started!");
            */
            AllLogger.Log(".\\log.txt", "Program Started!");

            //Simulating work by having the program sleep for 3 seconds
            Thread.Sleep(3000);

            /*
            ConsoleLogger.Log("Program Ender!");
            FileLogger.LogToFile(".\\log.txt", "Program Ended!");
            */
            AllLogger.Log(".\\log.txt", "Program Ended!");

        }
        /*
         * make an own class for this 
         * 
        //instead of writing FileLogger.LogToFile(".//log.txt", "Program Started!");
        //by added the parameter fileName and msg
        //we can write FileLogger.LogToFile(fileName, msg);
        static void Log(string fileName, string msg)
        {
            ConsoleLogger.Log(msg);
            FileLogger.LogToFile(fileName, msg);
        }
        */

    }
}
