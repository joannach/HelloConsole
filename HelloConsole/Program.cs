using System;

namespace HelloConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username: ");
            var username = Console.ReadLine();

            Console.WriteLine(string.Format("Hello, {0}", username));
        }
    }
}
