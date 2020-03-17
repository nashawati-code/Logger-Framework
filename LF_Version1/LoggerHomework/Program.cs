using System;

namespace LoggerHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Old method
             * 
             * //start
             * Console.WriteLine($"{DateTime.Now} Starting Email engine!")
             * //send emails
             * Console.WriteLine($"{DateTime.Now} Email engine started!");
            */

            /*
            Log("Starting Email Engine");
            Log("Email engine started!");
            */

            //call on the method without having to create an instance --> static method
            Logger.Log("You can do this!");

            //start
            Logger.Log("Starting Email engine!");
            //send emails
            Logger.Log("Email engine started!");

        }

        /*
        static void Log(string msg)
        {
            Console.WriteLine($"{DateTime.Now} {msg}");
        }
        */

        //^^^^^
        //since we're creating a framework we want to put void Log in a different class
    }
}
