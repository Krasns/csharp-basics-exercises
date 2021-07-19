using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            int Meters, Hour, Minutes, Seconds, TimeinSeconds, TimeinHours;
            double SpeedMS, SpeedKmh, SpeedMilH, Kilometre, Miles;

            Console.WriteLine("Test Data");
            Console.Write("Input distance in meters: ");
            Meters = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input hour: ");
            Hour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input minutes: ");
            Minutes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input seconds: ");
            Seconds = Convert.ToInt32(Console.ReadLine());
            
            TimeinSeconds = (Hour * 3600) + (Minutes * 60) + Seconds;
            TimeinHours = TimeinSeconds / 3600;
            Kilometre = Meters / 1000;
            Miles = Kilometre * 0.621371;

            Console.WriteLine("Expected Output :");
            SpeedMS = Meters / TimeinSeconds;
            Console.WriteLine("Your speed in meters/second is {0}", SpeedMS);
            SpeedKmh = Kilometre / TimeinHours;
            Console.WriteLine("Your speed in km/h is {0}", SpeedKmh);
            SpeedMilH = Miles / TimeinHours;
            Console.WriteLine("Your speed in miles/h is {0}", SpeedMilH);

            Console.ReadKey();
        }
    }
}
