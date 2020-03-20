using System.IO;
using LoggerCore;

/*
namespace Logger
{
    public class FileLogger : BaseLogger
    {
        //we declare a variable as private
        string fileName;

        //make a constructor that provides it a value
        public FileLogger(string fileName)
        {
            this.fileName = fileName;
        }

        protected override void SubClassLog(string msg)
        {
            File.AppendAllText(fileName, msg);
        }
    }
}
*/

namespace Logger
{
    //this was previously FileLogger : BaseLogger (as seen above)
    public class FileLogger : FileBaseLogger
    {
        //passes it to the base class constructor
        public FileLogger(string fileName, LogOutput logOutput) : base(fileName, logOutput)
        {

        }
        
        protected override void SubClassLog(string msg)
        {
            if(logOutput == LogOutput.OutputToBoth || logOutput == LogOutput.OutputToFile)
            {
                File.AppendAllText(fileName, msg);
            }
        }
    }
}