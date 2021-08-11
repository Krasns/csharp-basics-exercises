﻿using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            InitBoard();
        }

        private static void InitBoard()
        {
            int player = 0;
            int row;
            int column;
            int count = 0;
            string location;
            char[,] savingData = new char[3, 3];
            while (count != 2)
            {

                if (player == 0)
                {
                    Console.Write("'O', choose your location (row -> space -> column): ");
                    location = Console.ReadLine();
                    var data = location.Split(' ');
                    row = int.Parse(data[0]);
                    column = int.Parse(data[1]);

                    for (var r = 0; r < 3; r++)
                    {
                        for (var c = 0; c < 3; c++)
                        {
                            if (r == row && c == column)
                            {
<<<<<<< HEAD
                                board[r, c] = savingData[row,column] = 'O';
=======
                                board[r, c] = 'O';
                                savingData[row,column] = 'O';
>>>>>>> 31d12ec482505947182880d8ffcd2ca6c6e82353
                            }
                            else
                            {
                                board[r, c] = ' ';
                            }
                        }
                    }
<<<<<<< HEAD

                    for (var r = 0; r < 3; r++)
                    {
                        for (var c = 0; c < 3; c++)
                        {
                            board[r, c] = savingData[row, column];
                        }
                    }

=======
>>>>>>> 31d12ec482505947182880d8ffcd2ca6c6e82353
                    DisplayBoard();
                    player = 1;
                }
                else
                {
                    Console.Write("'X', choose your location (row -> space -> column): ");
                    location = Console.ReadLine();
                    var data = location.Split(' ');
                    row = int.Parse(data[0]);
                    column = int.Parse(data[1]);

                    for (var r = 0; r < 3; r++)
                    {
                        for (var c = 0; c < 3; c++)
                        {
                            if (r == row && c == column)
                            {
<<<<<<< HEAD
=======
                                board[r, c] = 'X';
>>>>>>> 31d12ec482505947182880d8ffcd2ca6c6e82353
                                savingData[row, column] = 'X';
                            }
                            else
                            {
                                board[r, c] = ' ';
                            }
                        }
                    }
<<<<<<< HEAD

                    for (var r = 0; r < 3; r++)
                    {
                        for (var c = 0; c < 3; c++)
                        {
                            board[r, c] = savingData[row, column];
                        }
                    }
                            DisplayBoard();
=======
                    DisplayBoard();
>>>>>>> 31d12ec482505947182880d8ffcd2ca6c6e82353
                    player = 0;
                }

                count++;
            }

        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
            Console.ReadKey();
        }
    }
}
