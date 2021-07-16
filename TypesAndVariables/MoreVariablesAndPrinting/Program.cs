using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            String Name, Eyes, Teeth, Hair;
            int Age;
            Double Height, Weight;

            Name = "Zed A. Shaw";
            Age = 35;
            Height = Math.Round(74 * 2.54,2);  // inches
            Weight = Math.Round(180 * 0.453592,2); // lbs
            Eyes = "Blue";
            Teeth = "White";
            Hair = "Brown";
            

            Console.WriteLine("Let's talk about " + Name + ".");
            Console.WriteLine("He's " + Height + " inches tall.");
            Console.WriteLine("He's " + Weight + " pounds heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + Eyes + " eyes and " + Hair + " hair.");
            Console.WriteLine("His teeth are usually " + Teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + Age + ", " + Height + ", and " + Weight
                               + " I get " + (Age + Height + Weight) + ".");

            Console.ReadKey();
        }
    }
}