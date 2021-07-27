using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] BasePay = { 7.50, 8.20, 10.00};
            int[] HoursWorked = { 35, 47, 73 };
            double Pay = 0;
            double OverTimePay = 0;
            int HoursWorkedOver = 0;

            for (int i = 0; i < BasePay.Length; i++)
            {
                if (HoursWorked[i] > 70 || BasePay[i] < 8)
                {
                    Console.WriteLine("Error!!");
                }
                else if (HoursWorked[i] > 40)
                {
                    HoursWorkedOver = HoursWorked[i] - 40;
                    OverTimePay = BasePay[i] + (BasePay[i] * 1.5);
                    Pay = 40 * BasePay[i] + (HoursWorkedOver * OverTimePay);
                    Console.WriteLine($"Employee {i+1} with BasePay {BasePay[i]} worked for {HoursWorked[i]} this week and did {HoursWorkedOver} and got ${Pay}");
                }
                else
                {
                    Pay = HoursWorked[i] * BasePay[i];
                    Console.WriteLine($"Employee {i + 1} with BasePay {BasePay[i]} worked for {HoursWorked[i]} this week and got ${Pay}");
                }
            }
            Console.ReadKey();
        }
    }
}
