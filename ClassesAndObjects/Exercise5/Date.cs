using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Date
    {
        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public void DisplayDate() 
        {
            Console.WriteLine($"{Day}/{Month}/{Year}");
        }
    }
}