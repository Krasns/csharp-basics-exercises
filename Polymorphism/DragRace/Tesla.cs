using System;

namespace DragRace
{
    public class Tesla : ICar
    {
        public int currentSpeed { get; set; }
        public Tesla()
        {
            currentSpeed = 0;
        }

        public void SpeedUp()
        {
            currentSpeed+=5;
        }

        public void SlowDown()
        {
            currentSpeed-=3;
        }
        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }
        public void StartEngine() 
        {
            Console.WriteLine("-- silence ---");
        }
    }
}