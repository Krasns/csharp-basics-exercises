﻿using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The first 10 natural numbers are: ");

            for (int i = 0; i < 11; i++)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
