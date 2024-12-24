using NUnit.Framework;
using RobotApp.Behaviors;
using RobotApp.Factories;
using RobotApp.Interfaces;
using System;

namespace RobotAppTest.Tests.UnitTests
{
    [TestFixture]
    public class MovementBehaviorTests
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
        public void WalkForward_ValidMove_UpdatesPosition()
        {
            var behavior = new StandardMovementBehavior(2, 2, 'N', _room, _logger);
            behavior.WalkForward();
            Assert.That(behavior.Report(), Is.EqualTo("2 3 N"));
        }

        [Test]
        public void TurnLeft_ChangesDirectionCorrectly()
        {
            var behavior = new StandardMovementBehavior(0, 0, 'N', _room, _logger);
            behavior.TurnLeft();
            Assert.That(behavior.Report(), Is.EqualTo("0 0 W"));
        }

        [Test]
        public void TurnRight_ChangesDirectionCorrectly()
        {
            var behavior = new StandardMovementBehavior(0, 0, 'N', _room, _logger);
            behavior.TurnRight();
            Assert.That(behavior.Report(), Is.EqualTo("0 0 E"));
        }

        [Test]
        public void WalkForward_OutOfBounds_ThrowsException()
        {
            var behavior = new StandardMovementBehavior(0, 0, 'S', _room, _logger);
            Assert.Throws<InvalidOperationException>(() => behavior.WalkForward());
        }
    }
}
