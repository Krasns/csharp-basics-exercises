using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Date
    {
        string _day;
        string _month;
        string _year;
        public Date(string day, string month, string year)
        {
            _day = day;
            _month = month;
            _year = year;
        }
        public string Day
        {
            get => _day;
            set => _day = value;
        }
        public string Month
        {
            get => _month;
            set => _month = value;
        }
        public string Year
        {
            get => _year;
            set => _year = value;
        }

        public void DisplayDate() 
        {
            Console.WriteLine($"{_month}/{_day}/{_year}");
        }
    }
}
