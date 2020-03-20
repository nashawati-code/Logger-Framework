using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerCore
{
    //CommonLogger takes care of the Log method
    public abstract class CommonLogger : InterfaceLogger
    {
        //we also need to add the parameters here
        protected abstract void SubClassLog(string msg);

        //no matter what logger, they all have to go through this
        protected string FormatOutput(string msg)
        {
            return $"{DateTime.Now}: {msg}\n";
        }

        //we know add parameters because we changed InterfaceLogger
        public void Log(string msg)
        {
            SubClassLog(FormatOutput(msg));
        }

        protected LogOutput logOutput;
        public CommonLogger(LogOutput logOutput)
        {
            this.logOutput = logOutput;
        }
    }
}

//now that we have CommonLogger, we can start making other classes inherit it