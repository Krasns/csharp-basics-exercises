using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var productOne = new Product("Logitech mouse", 70.00, 14);
            var productTwo = new Product("iPhone 5s", 999.99, 3);
            var productThree = new Product("Epson EB-U05", 440.46, 1);

            productOne.PrintProduct();
            productTwo.PrintProduct();
            productThree.PrintProduct();

            int number = 0;
            while (number != 3)
            {
            Console.WriteLine("1 - Change quantity");
            Console.WriteLine("2 - change price");
            Console.WriteLine("3 - End");
            Console.WriteLine("Enter number:");
            number = Convert.ToInt32(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        Console.Write("What is the new quantity: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        productOne.ChangeQuantity(quantity);
                        productOne.PrintProduct();
                        break;
                    case 2:
                        Console.Write("What is the new quantity: ");
                        double price = Convert.ToDouble(Console.ReadLine());
                        productOne.ChangePrice(price);
                        productOne.PrintProduct();
                        break;
                    case 3:
                        Console.WriteLine("Good bay!");
                        break;
                    default:
                        Console.WriteLine("Rong number!");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
