using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            var firstAccount = new Account("First Account", 100.00);
            firstAccount.Deposit(20.00);
            Console.WriteLine(firstAccount);

            var mattsAccount = new Account("Matts Account", 1000.00);
            var myAccount = new Account("My Account", 0);
            mattsAccount.Withdrawal(100);
            myAccount.Deposit(100);
            Console.WriteLine(mattsAccount);
            Console.WriteLine(myAccount);

            var aAccount = new Account("A account", 100.00);
            var bAccount = new Account("B account",0);
            var cAccount = new Account("C Account", 0);
            Console.WriteLine("Initial state");
            Console.WriteLine(aAccount);
            Console.WriteLine(bAccount);
            Console.WriteLine(cAccount);
            Transfer(aAccount,bAccount, 50.0);
            Transfer(bAccount,cAccount, 25.0);
            
            Console.WriteLine("Final state");
            Console.WriteLine(aAccount);
            Console.WriteLine(bAccount);
            Console.WriteLine(cAccount);

            Console.ReadKey();
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            to.Deposit(from.Withdrawal(howMuch));
        }
    }
}
