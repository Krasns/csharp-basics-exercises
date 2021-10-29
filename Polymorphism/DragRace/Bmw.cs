using System;

namespace DragRace
{
    public class Bmw : ICar
    {
        public int currentSpeed { get; set; }
        public Bmw()
        {
            currentSpeed = 0;
        }
        public void SpeedUp()
        {
            currentSpeed+=6;
        }
        public void SlowDown()
        {
            currentSpeed--;
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