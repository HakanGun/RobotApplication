using RobotApp.Interfaces;
using RobotApp.Logging;

namespace RobotApp.Factories
{
    public static class LoggerFactory
    {
        public static ILogger CreateLogger()
        {
            return new ConsoleLogger();
        }
    }
}
