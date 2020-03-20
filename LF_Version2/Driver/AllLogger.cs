using Logger253;
using LoggerCore;

/*
namespace Logger
{
    public class AllLogger : BaseLogger
    {
        string fileName;

        InterfaceLogger consoleLogger;
        InterfaceLogger fileLogger;

        public AllLogger(string fileName)
        {
            this.fileName = fileName;
            
            //in order to access these, we need to declare them at the class level
            //and initialize them in the constructor
            consoleLogger = new ConsoleLogger();
            fileLogger = new FileLogger(fileName);
        }

        protected override void SubClassLog(string msg)
        {
           
            //this isnt efficient,
            //since everytime we call Log we are creating an instance of consoleLogger and fileLogger and that takes time

            //InterfaceLogger consoleLogger = new ConsoleLogger();
            //consoleLogger.Log(msg);
            //InterfaceLogger fileLogger = new FileLogger(fileName);
            //fileLogger.Log(msg);
            

            //so we move the InterfaceLlogger lines to the constructor
            consoleLogger.Log(msg);
            fileLogger.Log(msg);
        }
    }
}
*/

//AFTER creating FileBaseLogger
namespace Logger
{
    public class AllLogger : FileBaseLogger
    {
        //NEW REQUIREMENT: as a programmer, I would like to selectively write to console
        //and/or file loggers from AllLogger.Log(

        InterfaceLogger consoleLogger;
        InterfaceLogger fileLogger;
        InterfaceLogger slackLogger;

        public AllLogger(string fileName, LogOutput logOutput) : base(fileName, logOutput)
        {
            this.consoleLogger = new ConsoleLogger(logOutput);
        }

        protected override void SubClassLog(string msg)
        {
            consoleLogger.Log(msg);
            fileLogger.Log(msg);
        }
    }
}