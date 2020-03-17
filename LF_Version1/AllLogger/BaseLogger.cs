using System;

namespace LoggerCore
{
    //it's abstract because it's constant
    //BaseLogger only knows that it should log, NOT HOW to log

    /*
     * This is NOT a good design
     * 
    public abstract class BaseLogger
    {
        public abstract void Log(string msg);
    }
    *
    */

    //A better design would be to create an Interface that defines the behavior
    //BaseLogger will implement InterfaceLogger
    public abstract class BaseLogger : InterfaceLogger
    {
        public abstract void Log(string msg);
    }

}