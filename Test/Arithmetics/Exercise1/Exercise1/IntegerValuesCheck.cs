using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class IntegerValuesCheck
    {
        private int _firstNumber;
        private int _secondNumber;
        private bool _FalseOrTrue;
        public IntegerValuesCheck(int firstNumber, int secondNumber)
        {
            _firstNumber = firstNumber;
            _secondNumber = secondNumber;
            _FalseOrTrue = false;
        }
        public int FirstNumber
        {
            get { return _firstNumber; }
        }
        public int SecondNumber
        {
            get { return _secondNumber; }
        }
        public bool Check()
        {
            IntegerCheck();
            return _FalseOrTrue;
        }
        public void IntegerCheck()
        {
            if (_firstNumber == 15 || _secondNumber == 15 || _firstNumber + _secondNumber == 15 ||
                _firstNumber - _secondNumber == 15 || _secondNumber - _firstNumber == 15)
                _FalseOrTrue = true;
            else
                _FalseOrTrue = false;
        }
    }
}
