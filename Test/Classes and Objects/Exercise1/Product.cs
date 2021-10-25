using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Product
    {
        string _name;
        double Price;
        int Amount;
        public Product(string name, double priceAtStart, int amountAtStart)
        {
            _name = name;
            Price = priceAtStart;
            Amount = amountAtStart;
        }
        public void PrintProduct()
        {
            Console.WriteLine($"{_name}, price {Price}, amount {Amount}");
        }
        public void ChangeQuantity(int quantityChange)
        {
            Amount = quantityChange;
        }
        public void ChangePrice(double quantityPrice)
        {
            Price = quantityPrice;
        }
    }
}
