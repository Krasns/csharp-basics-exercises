﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Movies
    {
        string _title;
        string _studio;
        string _rating;
        public Movies(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            _rating = rating;
        }
        public Movies(string title, string studio)
        {
            _title = title;
            _studio = studio;
        }
        public string[] GetPG(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == "PG")
                {
                
                }
            }
            return arr;
        }
    }
}
