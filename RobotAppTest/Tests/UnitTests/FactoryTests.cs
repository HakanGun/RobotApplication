using NUnit.Framework;
using RobotApp.Factories;
using RobotApp.Interfaces;
using RobotApp.Models;

namespace RobotAppTest.Tests.UnitTests
{
    [TestFixture]
    public class FactoryTests
    {
        [Test]
        public void RobotFactory_CreatesValidRobot()
        {
            IRoom room = RoomFactory.CreateRoom(5, 5);
            ILogger logger = LoggerFactory.CreateLogger();
            var robot = RobotFactory.CreateRobot(1, 2, 'N', room, logger);

            Assert.IsInstanceOf<Robot>(robot);
            Assert.That(robot.Report(), Is.EqualTo("1 2 N"));
        }

        [Test]
        public void RoomFactory_CreatesValidRoom()
        {
            IRoom room = RoomFactory.CreateRoom(5, 5);
            Assert.IsTrue(room.IsWithinBounds(0, 0));
            Assert.IsFalse(room.IsWithinBounds(5, 5));
        }

        [Test]
        public void LoggerFactory_CreatesValidLogger()
        {
            ILogger logger = LoggerFactory.CreateLogger();
            Assert.IsNotNull(logger);
        }
    }
}
