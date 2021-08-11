using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] basePay = { 7.50, 8.20, 10.00};
            int[] hoursWorked = { 35, 47, 73 };
            double pay = 0;
            double OverTimePay = 0;
            int HoursWorkedOver = 0;

            for (int i = 0; i < basePay.Length; i++)
            {
                if (hoursWorked[i] > 70 || basePay[i] < 8)
                {
                    Console.WriteLine("Error!!");
                }
                else if (hoursWorked[i] > 40)
                {
                    HoursWorkedOver = hoursWorked[i] - 40;
                    OverTimePay = basePay[i] + (basePay[i] * 1.5);
                    pay = 40 * basePay[i] + (HoursWorkedOver * OverTimePay);
                    Console.WriteLine($"Employee {i+1} with BasePay {basePay[i]} worked for {hoursWorked[i]} this week and did {HoursWorkedOver} and got ${pay}");
                }
                else
                {
                    pay = hoursWorked[i] * basePay[i];
                    Console.WriteLine($"Employee {i + 1} with BasePay {basePay[i]} worked for {hoursWorked[i]} this week and got ${pay}");
                }
            }
            Console.ReadKey();
        }
    }
}
