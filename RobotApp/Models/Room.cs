using RobotApp.Interfaces;

namespace RobotApp.Models
{
    public class Room : IRoom
    {
        private readonly int _width;
        private readonly int _height;

        public Room(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public bool IsWithinBounds(int x, int y)
        {
            return x >= 0 && x < _width && y >= 0 && y < _height;
        }
    }
}
