using System;
using System.Collections.Generic;
using System.Text;
using LoggerCore;

namespace LoggerCore
{
    //we are going to define an enum
    public enum LogOutput
    {
        OutputToFile,
        OutputToConsole,
        OutputToBoth,
        OutputToSlackChannel
    }
    
    public interface InterfaceLogger
    {
        void Log(string msg);
    }
}
