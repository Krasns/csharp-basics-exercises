using System;

namespace Exercise8_SavingsAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much money is in the account? ");
            int money = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the annual interest rate: ");
            int annualInterestRate = Convert.ToInt32(Console.ReadLine());
            Console.Write("How long has the account been opened? ");
            int time = Convert.ToInt32(Console.ReadLine());
        
            var p1 = new SavingsAccount(money);

            int count = 0;
            int deposited = 0;
            int withdrawn = 0;
            while (count !=time)
            {
                Console.Write($"Enter amount deposited for month: {count+1}: ");
                deposited = Convert.ToInt32(Console.ReadLine());
                p1.Deposit(deposited);
                Console.Write($"Enter amount withdrawn for {count+1}: ");
                withdrawn = Convert.ToInt32(Console.ReadLine());
                p1.WithDrawal(withdrawn);
                count++;
                p1.MonthlyInterest(annualInterestRate);
            }
            p1.TotalShown();
        }
    }
}
