using System;
using System.Collections.Generic;
using System.Text;

namespace Firm
{
    class Commission : Hourly
    {
        private double _totalSales;
        private double _commission;
    
        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commision) : base(eName,
                eAddress, ePhone, socSecNumber, rate)
        {
            _commission = commision;
            _totalSales = 0;
        }
        public void AddSales(double totalSales)
        {
            _totalSales += totalSales;
        }
        public override double Pay()
        {
            var payment = base.Pay() + ( _totalSales * _commission);
            _totalSales = 0;
            return Math.Round(payment,2);
        }
        public override string ToString()
        {
            var result = base.ToString();
            return result;
        }
    }

}
