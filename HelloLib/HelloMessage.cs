using System;

namespace HelloLib
{
    public static class HelloMessage
    {
        public static string SetHelloUsernameMessage(string username)
        {
            return string.Format("{0} Hello, {1}!", DateTime.UtcNow, username);
        }
    }
}
