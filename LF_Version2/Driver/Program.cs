using Logger;
using Logger253;
using LoggerCore;
using System.Threading;

namespace Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfaceLogger allLogger = new AllLogger(".\\log.txt", LogOutput.OutputToBoth);

            //we add an enum
            allLogger.Log("===== Final Start =====");

            Thread.Sleep(3000);

            allLogger.Log("===== Final End =====");
        }

    }
}
