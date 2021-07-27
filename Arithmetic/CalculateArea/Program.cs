﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice; // The user's menu choice

            do
            {
                // Get the user's menu choice.
                choice = getMenu();

                if (choice == 1)
                {
                    calculateCircleArea();
                    Console.ReadKey();
                }
                else if (choice == 1)
                {
                    calculateRectangleArea();
                    Console.ReadKey();
                }
                else if (choice == 3)
                {
                    calculateTriangleArea();
                    Console.ReadKey();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Thanks for calculating!");
                    Console.ReadKey();
                }

            } while (choice != 4);
        }

        public static int getMenu()
        {

            int userChoice;
            
            // keyboard input

            // Display the menu.
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Console.ReadKey();
            Console.WriteLine();
            // get input from user
            int.TryParse(keyboard.KeyChar.ToString(), out userChoice);

            // validate input
            while (userChoice < 1 || userChoice > 4)
            {
                Console.WriteLine("Please enter a valid range: 1, 2, 3, or 4: ");
                keyboard = Console.ReadKey();
                userChoice = keyboard.KeyChar;
            }

            return userChoice;
        }

        public static void calculateCircleArea()
        {
            // Get input from user
            Console.WriteLine("What is the circle's radius? ");
            //todo
            var keyboard = Console.ReadLine();

<<<<<<< HEAD
            decimal.TryParse(keyboard, out var radius);
=======
            double.TryParse(keyboard, out var radius);
>>>>>>> parent of 2c5ac60 (Exercise 10 CalculateArea reworked)

            // Display output
            Console.WriteLine($"The circle's area is {Math.Round(Math.PI * radius * radius,2)}");
        }

        public static void calculateRectangleArea()
        {
            decimal length = 0;
            decimal width = 0;

            // Get length
            Console.WriteLine("Enter length? ");
            //todo
            //length = keyboard.nextDouble();

            // Get width
            Console.WriteLine("Enter width? ");
            //todo
            //width = keyboard.nextDouble();

            // Display output
            Console.WriteLine($"The rectangle's area is {Math.Round(length *width, 2)}");
        }

        public static void calculateTriangleArea()
        {
            double ground = 0;
            double height = 0;

            // Get input from user
            var keyboard = Console.ReadKey();

            // Get the base
            Console.WriteLine("Enter length of the triangle's base? ");
<<<<<<< HEAD
            //todo
            //read key value

            // Get the height
            Console.WriteLine("Enter triangle's height? ");
            //todo
            //read key value
=======
            ground = Convert.ToDouble(Console.ReadLine());

            // Get the height
            Console.WriteLine("Enter triangle's height? ");
            height = Convert.ToDouble(Console.ReadLine());
>>>>>>> parent of 2c5ac60 (Exercise 10 CalculateArea reworked)

            // Display the triangle's area.
            Console.WriteLine($"The triangle's area is {Math.Round(ground*height*0.5,2)}");
        }
    }
}
