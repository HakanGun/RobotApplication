using NUnit.Framework;
using RobotApp.Factories;
using RobotApp.Interfaces;
using RobotApp.Models;

namespace RobotAppTest.Tests.UnitTests
{
    [TestFixture]
    public class RobotTests
    {
        private IRoom _room;
        private ILogger _logger;

        [SetUp]
        public void Setup()
        {
            _room = RoomFactory.CreateRoom(5, 5);
            _logger = LoggerFactory.CreateLogger();
        }

        [Test]
        public void ExecuteCommands_ValidCommands_ProducesExpectedResult()
        {
            var robot = RobotFactory.CreateRobot(1, 2, 'N', _room, _logger);
            robot.ExecuteCommands("RFRFFRFRF");
            Assert.That(robot.Report(), Is.EqualTo("1 1 N"));
        }

        [Test]
        public void ExecuteCommands_InvalidCommand_ThrowsException()
        {
            var robot = RobotFactory.CreateRobot(1, 2, 'N', _room, _logger);
            Assert.Throws<InvalidOperationException>(() => robot.ExecuteCommands("X"));
        }

        [Test]
        public void WalkForward_OutOfBounds_ThrowsException()
        {
            var robot = RobotFactory.CreateRobot(0, 0, 'S', _room, _logger);
            Assert.Throws<InvalidOperationException>(() => robot.ExecuteCommands("F"));
        }
    }
}
