using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Logger253;

/*
 * BEFORE referencing LoggerCore in the Dependencies
 * 
namespace Logger253
{
    public class FileLogger
    {
        //we can also call this Log instead of LogToFile --> refactoring
        public static void LogToFile(string fileName, string msg)
        {
            File.AppendAllText(fileName, $"{DateTime.Now} {msg}");
        }

    }
}
*/

using LoggerCore;

/*
 * //PROBLEM
 * //...we don't want to pass fileName everytime, we only want to pass it one time only
 * 
namespace Logger253
{
    public class FileLogger : BaseLogger
    {
        //we can also call this Log instead of LogToFile --> refactoring
        public static void LogToFile(string fileName, string msg)
        {
            File.AppendAllText(fileName, $"{DateTime.Now} {msg}\n");
        }

       

        public override void Log(string msg)
        {
            throw new NotImplementedException();
        }
    }
}
*/

//TO SOLVE THIS PROBLEM
namespace Logger253
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

        public override void Log(string msg)
        {
            throw new NotImplementedException();
        }
    }
}

//we now go to AllLogger to create an INSTANCE