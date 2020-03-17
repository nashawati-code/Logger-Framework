using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerCore
{
    interface InterfaceLogger
    {
        //we are simply defining the behavior
        void Log(string msg);

        //BaseLogger will implement this Interface
    }
}
