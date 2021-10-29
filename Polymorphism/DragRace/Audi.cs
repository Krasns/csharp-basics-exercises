using System;

namespace DragRace
{
    public class Audi : ICar
    {
        public int currentSpeed { get; set; }
        public Audi()
        {
            currentSpeed = 0;
        }
        public void SpeedUp()
        {
            currentSpeed+=2;
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