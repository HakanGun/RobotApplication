using RobotApp.Interfaces;
using RobotApp.Models;

namespace RobotApp.Factories
{
    public static class RoomFactory
    {
        public static IRoom CreateRoom(int width, int height)
        {
            return new Room(width, height);
        }
    }
}
