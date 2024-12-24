using System;
using System.Collections.Generic;
using RobotApp.Interfaces;

namespace RobotApp.Behaviors
{
    public class StandardMovementBehavior : IMovementBehavior
    {
        private int _x;
        private int _y;
        private char _direction;
        private readonly IRoom _room;
        private readonly ILogger _logger;

        private static readonly Dictionary<char, (int dx, int dy)> Directions = new()
        {
            {'N', (0, 1)},
            {'E', (1, 0)},
            {'S', (0, -1)},
            {'W', (-1, 0)}
        };

        private static readonly List<char> DirectionOrder = new() { 'N', 'E', 'S', 'W' };

        public StandardMovementBehavior(int startX, int startY, char startDirection, IRoom room, ILogger logger)
        {
            _x = startX;
            _y = startY;
            _direction = startDirection;
            _room = room;
            _logger = logger;
        }

        public void TurnLeft()
        {
            int currentIndex = DirectionOrder.IndexOf(_direction);
            _direction = DirectionOrder[(currentIndex + 3) % 4];
            _logger.Log($"Turned Left. Now facing {_direction}");
        }

        public void TurnRight()
        {
            int currentIndex = DirectionOrder.IndexOf(_direction);
            _direction = DirectionOrder[(currentIndex + 1) % 4];
            _logger.Log($"Turned Right. Now facing {_direction}");
        }

        public void WalkForward()
        {
            var (dx, dy) = Directions[_direction];
            int newX = _x + dx;
            int newY = _y + dy;

            if (!_room.IsWithinBounds(newX, newY))
            {
                _logger.Log($"Error: Robot walked out of bounds to ({newX}, {newY})");
                throw new InvalidOperationException("Error: Robot walked out of bounds.");
            }

            _x = newX;
            _y = newY;
            _logger.Log($"Moved to ({_x}, {_y}) facing {_direction}");
        }

        public string Report()
        {
            return $"{_x} {_y} {_direction}";
        }
    }
}
