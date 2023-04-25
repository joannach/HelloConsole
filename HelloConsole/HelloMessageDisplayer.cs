using HelloLib;
using System;

namespace HelloConsole
{
    public static class HelloMessageDisplayer
    {
        public static void DisplayMessageForUser()
        {
            Console.WriteLine("Enter username: ");
            var username = Console.ReadLine();

            var message = SetHelloMessageWithDate(username);

            Console.WriteLine(message);
        }

        private static string SetHelloMessage(string username)
        {
            return string.Format("Hello, {0}", username);
        }

        private static string SetHelloMessageWithDate(string username)
        {
            return HelloMessage.SetHelloUsernameMessage(username);
        }
    }
}
