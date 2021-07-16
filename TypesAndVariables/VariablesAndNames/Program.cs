using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int Cars, Drivers, Passengers, Cars_Not_Driven, Capacity, Passengers_Per_Car;

            Cars = 100;
            Drivers = 2;
            Passengers = 90;
            Cars_Not_Driven = 10;
            Capacity = 16;
            Passengers_Per_Car = 3;

            Console.WriteLine("There are " + Cars + " cars available.");
            Console.WriteLine("There are only " + Drivers + " drivers available.");
            Console.WriteLine("There will be " + Cars_Not_Driven + " empty cars today.");
            Console.WriteLine("We can transport " + Capacity + " people today.");
            Console.WriteLine("We have " + Passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + Passengers_Per_Car + " in each car.");
            Console.ReadKey();
        }
    }
}