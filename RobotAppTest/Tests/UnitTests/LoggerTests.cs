using NUnit.Framework;
using RobotApp.Factories;
using RobotApp.Interfaces;
using System;
using System.IO;

namespace RobotAppTest.Tests.UnitTests
{
    [TestFixture]
    public class LoggerTests
    {
        [Test]
        public void Log_Message_PrintsToConsole()
        {
            ILogger logger = LoggerFactory.CreateLogger();
            var writer = new StringWriter();
            Console.SetOut(writer);

            logger.Log("Test message");

            Assert.IsTrue(writer.ToString().Contains("Test message"));
        }
    }
}
