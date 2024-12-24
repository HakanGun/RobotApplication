using RobotApp.Interfaces;
using RobotApp.Models;

namespace RobotApp.Controllers
{
    public class RobotController
    {
        private readonly IRobot _robot;

        public RobotController(IRobot robot)
        {
            _robot = robot;
        }

        public void Run(string commands)
        {
            _robot.ExecuteCommands(commands);
        }

        public string Report()
        {
            return _robot.Report();
        }
    }
}
