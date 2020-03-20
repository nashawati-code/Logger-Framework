using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public class Driver
    {
        public static void Log(string msg)d
        {
            Console.WriteLine($"{DateTime.Now} {msg}");
        }
    }
}
