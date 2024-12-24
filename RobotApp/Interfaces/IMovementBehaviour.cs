namespace RobotApp.Interfaces
{
    public interface IMovementBehavior
    {
        void TurnLeft();
        void TurnRight();
        void WalkForward();
        string Report();
    }
}
