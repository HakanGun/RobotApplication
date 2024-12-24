using RobotApp.Interfaces;
using System;

namespace RobotApp.Logging
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
