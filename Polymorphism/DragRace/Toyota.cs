using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRace
{
    class Toyota : ICar
    {
        public int currentSpeed { get; set; }
        public Toyota()
        {
            currentSpeed = 0;
        }
        public void SpeedUp()
        {
            currentSpeed += 4;
        }
        public void SlowDown()
        {
            currentSpeed -= 4;
        }
        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }
        public void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}
