using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRace
{
    class Honda : ICar, IBoost
    {
        public int currentSpeed { get; set; }
        public Honda()
        {
            currentSpeed = 0;
        }
        public void SpeedUp()
        {
            currentSpeed+=4;
        }
        public void SlowDown()
        {
            currentSpeed-=2;
        }
        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }
        public void UseNitrousOxideEngine()
        {
            currentSpeed += 2;
        }
        public void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}
