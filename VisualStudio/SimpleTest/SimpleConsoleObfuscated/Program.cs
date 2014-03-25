using System;

namespace SimpleConsoleObfuscated
{
    internal class Program
    {
        private static void Main()
        {
            var test = new A.CO_SimpleClassLibrary_MainClass();

            var message = test.CO_GetString();

            Console.WriteLine("Obfuscated: " + message);

            Console.ReadLine();
        }
    }
}