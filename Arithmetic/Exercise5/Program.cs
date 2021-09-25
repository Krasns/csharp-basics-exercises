using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int RandNumber, EnterNumber;

            Random r = new Random();
            RandNumber = r.Next(1, 100);

            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
            EnterNumber = Convert.ToInt32(Console.ReadLine());

            if (EnterNumber == RandNumber)
            {
                Console.WriteLine("You guessed it!  What are the odds?!?");
            }
            else if (EnterNumber > RandNumber)
            {
                Console.WriteLine($"Sorry, you are too high.  I was thinking of {RandNumber}.");
            }
            else
            {
                Console.WriteLine($"Sorry, you are too low.  I was thinking of {RandNumber}.");
            }

            Console.ReadKey();
        }
    }
}
