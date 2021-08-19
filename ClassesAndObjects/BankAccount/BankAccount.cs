using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccount
    {
        string Name;
        double Balance;
        public BankAccount(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }
        public string ShowUserNameAndBalance()
        {
            return $"{Name}, ${Math.Abs(Math.Round(Balance,2))}";
        }
    }
}
