using System;

namespace Exercise8_AsciiFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 8*2; j++)
                {
                    if (i == 0 && j < 8)
                    {
                        Console.Write("/");
                    }
                    else if (i == 0 && j < 16)
                    {
                        Console.Write("\\");
                    }
                    else if (i == 1 && j < 4)
                    {
                        Console.Write("/");
                    }
                    else if (i == 1 && j > 4 && j <= 12)
                    {
                        Console.Write("*");
                    }
                    else if (i == 1 && j > 12 && j <= 16)
                    {
                        Console.Write("\\");
                    }
                    else if (i == 2)
                    {
                        Console.Write("*");
                    }

                }
                    Console.WriteLine();
            }
        }
    }
}
