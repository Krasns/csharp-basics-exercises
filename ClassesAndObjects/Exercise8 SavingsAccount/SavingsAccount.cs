using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8_SavingsAccount
{
    class SavingsAccount
    {
        double Amount;
        int TotalDeposited;
        int TotalWithDrawn;
        double TotalInterestEarned;
        public SavingsAccount(int amount)
        {
            Amount = amount;
        }
        public void WithDrawal(int amountWithDrawn)
        {
            Amount -= amountWithDrawn;
            TotalWithDrawn += amountWithDrawn;
        }
        public void Deposit(int amountDeposit) 
        {
            Amount += amountDeposit;
            TotalDeposited += amountDeposit;
        }
        public void MonthlyInterest(double interestRate) 
        {
            TotalInterestEarned += (interestRate / 12) * Amount;
            Amount += (interestRate / 12) * Amount;
        }
        public void TotalShown()
        {
            Console.WriteLine($"Total deposited: ${TotalDeposited}.00");
            Console.WriteLine($"Total withdrawn: ${TotalWithDrawn}.00");
            Console.WriteLine($"Interest earned: ${Math.Round(TotalInterestEarned,2)}");
            Console.WriteLine($"Ending balance: ${Math.Round(Amount,2)}");
        }
    }
}
