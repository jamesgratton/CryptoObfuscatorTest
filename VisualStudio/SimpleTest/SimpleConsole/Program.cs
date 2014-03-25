using System;
using SimpleClassLibrary;

namespace SimpleConsole
{
    internal class Program
    {
        private static void Main()
        {
            var test = new MainClass();

            var message = test.GetString();

            Console.WriteLine("UnObfuscated: " + message);

            Console.ReadLine();
        }
    }
}