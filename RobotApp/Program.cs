using RobotApp.Factories;
using RobotApp.Interfaces;
using System;

namespace RobotApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter room size (width height):");
                string? roomSizeInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(roomSizeInput))
                {
                    throw new InvalidOperationException("Room size input cannot be empty.");
                }

                string[] roomSize = roomSizeInput.Split(' ');
                if (roomSize.Length != 2 || !int.TryParse(roomSize[0], out int width) || !int.TryParse(roomSize[1], out int height))
                {
                    throw new FormatException("Invalid room size input. Please enter two integers separated by space.");
                }

                IRoom room = RoomFactory.CreateRoom(width, height);

                Console.WriteLine("Enter starting position (x y direction):");
                string? startPositionInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(startPositionInput))
                {
                    throw new InvalidOperationException("Starting position input cannot be empty.");
                }

                string[] startPosition = startPositionInput.Split(' ');
                if (startPosition.Length != 3 ||
                    !int.TryParse(startPosition[0], out int startX) ||
                    !int.TryParse(startPosition[1], out int startY) ||
                    startPosition[2].Length != 1)
                {
                    throw new FormatException("Invalid starting position input. Please enter two integers and a direction (N, E, S, W).");
                }

                char startDirection = char.ToUpper(startPosition[2][0]);
                if ("NESW".IndexOf(startDirection) == -1)
                {
                    throw new ArgumentException("Invalid direction. Allowed values are N, E, S, W.");
                }

                ILogger logger = LoggerFactory.CreateLogger();
                var robot = RobotFactory.CreateRobot(startX, startY, startDirection, room, logger);

                Console.WriteLine("Enter navigation commands:");
                string? commandsInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(commandsInput))
                {
                    throw new InvalidOperationException("Commands input cannot be empty.");
                }

                string commands = commandsInput.ToUpper();
                robot.ExecuteCommands(commands);

                Console.WriteLine($"Report: {robot.Report()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
