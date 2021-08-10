using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, eyes, teeth, hair;
            int Age;
            Double height, weight;

            name = "Zed A. Shaw";
            Age = 35;
            height = Math.Round(74 * 2.54,2);
            weight = Math.Round(180 * 0.453592,2);
            eyes = "Blue";
            teeth = "White";
            hair = "Brown";
            

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + height + " inches tall.");
            Console.WriteLine("He's " + weight + " pounds heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + Age + ", " + height + ", and " + weight
                               + " I get " + (Age + height + weight) + ".");

            Console.ReadKey();
        }
    }
}