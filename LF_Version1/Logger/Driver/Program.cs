using System;
using System.Threading;

namespace Logger
{
    public class Program
    {
        public static void Main(string[] args) //send email to all students
        {
            Console.WriteLine($"{DateTime.Now} Program Started");
            Thread.Sleep(3000); //Simulating work by having the program for 3 seconds
            Console.WriteLine($"Program Ended"); //programmer forgot to include time stamp
        }

        public static void Log(string msg)
        {
            Console.WriteLine($"{DateTime.Now} {msg}");
        }
    }
}
