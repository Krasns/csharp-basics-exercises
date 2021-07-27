using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number from 1 to 7: ");
            int day = Convert.ToInt32(Console.ReadLine());

            if (day > 1 && day < 7)
            {
                switch (day)
                {
                    case 1:
                        Console.WriteLine("You have selected Monday!");
                        break;
                    case 2:
                        Console.WriteLine("You have selected Tuesday!");
                        break;
                    case 3:
                        Console.WriteLine("You have selected Wednesday!");
                        break;
                    case 4:
                        Console.WriteLine("You have selected Thursday!");
                        break;
                    case 5:
                        Console.WriteLine("You have selected Friday!");
                        break;
                    case 6:
                        Console.WriteLine("You have selected Sunday!");
                        break;
                    case 7:
                        Console.WriteLine("You have selected Saturday!");
                        break;
                }
            }
            else
                Console.WriteLine("Next time enter number from 1 to 7!");

            Console.ReadKey();
        }
    }
}
