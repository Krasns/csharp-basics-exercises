using System;

namespace Exercise7_Piglet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piglet!");
            Random rand = new Random();
            int number = rand.Next(1, 7);
            int sum = 0;

            if (number == 1)
            {
                Console.WriteLine($"You rolled {number}");
            }

            string answer = "";
            while (answer != "no" && number != 1)
            {
                number = rand.Next(1,7);
                sum += number;
                Console.WriteLine($"You rolled {number}");
                Console.Write("Roll again? ");
                answer = Console.ReadLine();
            }
            if (number == 1)
            {
                Console.WriteLine("You got 0 points.");
            }
            else
            {
                Console.WriteLine($"You got {sum} points.");
            }
        }
    }
}
