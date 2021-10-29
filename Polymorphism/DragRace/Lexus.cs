using System;

namespace DragRace
{
    public class Lexus : ICar, IBoost
    {
        public int currentSpeed { get; set; }
        public Lexus()
        {
            currentSpeed = 0;
        }
        public void SpeedUp()
        {
            currentSpeed+=3;
        }
        public void SlowDown()
        {
            currentSpeed--;
        }
        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }
        public void UseNitrousOxideEngine()
        {
            currentSpeed+=6;
        }
        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}