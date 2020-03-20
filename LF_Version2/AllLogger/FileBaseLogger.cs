using System;
using System.Collections.Generic;
using System.Text;
using LoggerCore;

namespace LoggerCore
{
    //this was previously FileBaseLogger : InterfaceLogger
    //however, we change it now since we made a new class called CommonLogger
    public abstract class FileBaseLogger : CommonLogger
    {
        //to make it available we added protected
        protected string fileName;

        public FileBaseLogger(string fileName, LogOutput logOutput) : base(logOutput)
        {
            this.fileName = fileName;
        }

        /*
         * We remove this since it's already implemented in CommonLogger
         * 
        public void Log(string msg)
        {
            throw new NotImplementedException();
        }
        */
    }
}
