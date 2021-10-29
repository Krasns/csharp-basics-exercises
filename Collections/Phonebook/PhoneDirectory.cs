using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> _data { get; set; }
        private int _dataCount;

        public PhoneDirectory()
        {
            _data = new SortedDictionary<string,string> ();
            _dataCount = 0;
        }

        private int Find(string name)
        {
            for (var i = 0; i < _dataCount; i++)
            {
                if (_data.Keys.Equals(name))
                {
                    return i;
                }
            }

            return -1;
        }

        public string GetNumber(string name)
        {
            var position = Find(name);
            if (position == -1)
            {
                return null;
            }
            else
            {
                return _data.Values.ToString();
            }
        }

        public void PutNumber(string name, string number)
        {
            if (name == null || number == null)
            {
                throw new Exception("name and number cannot be null");
            }

            var i = Find(name);
            if (i >= 0)
            {
                _data.Add(name,number);
            }
            else
            {
                var newEntry = new SortedDictionary<string, string> ();
                newEntry.Add(name, number);
                _data = newEntry;
                _dataCount++;
            }
        }
    }
}