using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            double Weight, Height, BMI;

            Console.Write("Enter weight in kg: ");
            Weight = Convert.ToInt32(Console.ReadLine()) * 2.20462;
            Console.Write("Enter height in cm: ");
            Height = Convert.ToInt32(Console.ReadLine()) * 0.393701;

            BMI = (Weight * 703) / (Height * Height);

            if (BMI < 18.5)
            {
                Console.WriteLine($"your BMI is {BMI} ,eat more!!");
            }
            else if (BMI > 18.5 && BMI < 25)
            {
                Console.WriteLine($"your BMI is {BMI} ,you are good!!");
            }
            else
            {
                Console.WriteLine($"your BMI is {BMI} ,eat less!!");
            }
            Console.ReadKey();
        }
    }
}
