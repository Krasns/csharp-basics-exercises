﻿using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
<<<<<<< HEAD
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
=======
            int cars, drivers, passengers, cars_not_driven, cars_driven;
            double seats_in_a_car, carpool_capacity, average_passengers_per_car;

            cars = 100; //cars
            seats_in_a_car = 4.0; //seats in a car
            drivers = 28; // drivers
            passengers = 90; // passengers
            //cars_not_driven  // free cars
            //cars_driven ; // cars driven at the moment
            //carpool_capacity = // carpool capacity
            //average_passengers_per_car = // average passengers per car

            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + cars_not_driven + " empty cars today.");
            Console.WriteLine("We can transport " + carpool_capacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + average_passengers_per_car + " in each car.");
>>>>>>> parent of d7d9aea (VariablesAndNames done)
            Console.ReadKey();
        }
    }
}