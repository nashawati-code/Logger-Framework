using System;
using System.Collections.Generic;
using System.Text;

//beacause they both have the same namespace, they have access to eachother
namespace LoggerHomework
{
    public class Logger
    {
        //static method is a class member
        //static means it's always available
        public static void Log(string msg)
        {
            Console.WriteLine($"{DateTime.Now} {msg}");
        }

        //non-static is an instance member
        public void foo()
        {

        }

    }
}
