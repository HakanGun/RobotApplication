using RobotApp.Interfaces;
using RobotApp.Models;
using RobotApp.Behaviors;

namespace RobotApp.Factories
{
    public static class RobotFactory
    {
        public static Robot CreateRobot(int x, int y, char direction, IRoom room, ILogger logger)
        {
            IMovementBehavior behavior = new StandardMovementBehavior(x, y, direction, room, logger);
            return new Robot(behavior);
        }
    }
}
