using RobotApp.Interfaces;

namespace RobotApp.Models
{
    public class Robot
    {
        private readonly IMovementBehavior _movementBehavior;

        public Robot(IMovementBehavior movementBehavior)
        {
            _movementBehavior = movementBehavior;
        }

        public void ExecuteCommands(string commands)
        {
            foreach (char command in commands)
            {
                switch (command)
                {
                    case 'L':
                        _movementBehavior.TurnLeft();
                        break;
                    case 'R':
                        _movementBehavior.TurnRight();
                        break;
                    case 'F':
                        _movementBehavior.WalkForward();
                        break;
                    default:
                        throw new InvalidOperationException($"Invalid command: {command}");
                }
            }
        }

        public string Report()
        {
            return _movementBehavior.Report();
        }
    }
}
