using NUnit.Framework;
using RobotApp.Factories;
using RobotApp.Interfaces;

namespace RobotAppTest.Tests.UnitTests
{
    [TestFixture]
    public class RoomTests
    {
        [Test]
        public void IsWithinBounds_ValidPosition_ReturnsTrue()
        {
            IRoom room = RoomFactory.CreateRoom(5, 5);
            Assert.IsTrue(room.IsWithinBounds(2, 3));
        }

        [Test]
        public void IsWithinBounds_OutOfBoundsPosition_ReturnsFalse()
        {
            IRoom room = RoomFactory.CreateRoom(5, 5);
            Assert.IsFalse(room.IsWithinBounds(5, 5));
        }

        [Test]
        public void IsWithinBounds_NegativePosition_ReturnsFalse()
        {
            IRoom room = RoomFactory.CreateRoom(5, 5);
            Assert.IsFalse(room.IsWithinBounds(-1, 2));
        }
    }
}
