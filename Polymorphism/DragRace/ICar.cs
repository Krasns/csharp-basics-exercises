using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRace
{
    interface ICar
    {
        int currentSpeed { get; set; }
        void SpeedUp();
        void SlowDown();
        string ShowCurrentSpeed();
        void StartEngine();
    }
}
