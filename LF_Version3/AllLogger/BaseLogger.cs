using System;

/*
namespace LoggerCore
{
    public abstract class BaseLogger : InterfaceLogger
    {
        
       //We remove this and add it to CommonLogger.cs
         
       //protected string FormatOutput(string msg)
       //{
       //    return $"{DateTime.Now}: {msg}\n";
       //}

       //public abstract void SubClassLog(string msg);
      

        public void Log(string msg)
        {
            SubClassLog(FormatOutput(msg));
        }
    }
}
*/

namespace LoggerCore
{
    //this was previously BaseLogger : InterfaceLogger
    public abstract class BaseLogger : CommonLogger
    {
        //overloaded constructor
        //we pass it to base, because base stores it as a protected field
        public BaseLogger(LogOutput logOutput) : base(logOutput)
        {

        }
    }
}