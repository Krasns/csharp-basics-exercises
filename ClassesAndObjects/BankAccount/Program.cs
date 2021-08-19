using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount benson = new BankAccount("Benso", 17.22);
            BankAccount karlis = new BankAccount("Karlis", -12.32);
            BankAccount toms = new BankAccount("Toms", 17.225);

            Console.WriteLine(benson.ShowUserNameAndBalance());
            Console.WriteLine(karlis.ShowUserNameAndBalance());
            Console.WriteLine(toms.ShowUserNameAndBalance());
            Console.ReadKey();
        }
    }
}
