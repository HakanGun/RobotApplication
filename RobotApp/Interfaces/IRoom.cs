using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotApp.Interfaces
{
    public interface IRoom
    {
        bool IsWithinBounds(int x, int y);
    }
}
