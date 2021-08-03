using System;

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
                                board[r, c] = 'O';
                                savingData[row,column] = 'O';
                            }
                            else
                            {
                                board[r, c] = ' ';
                            }
                        }
                    }
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
                                board[r, c] = 'X';
                                savingData[row, column] = 'X';
                            }
                            else
                            {
                                board[r, c] = ' ';
                            }
                        }
                    }
                    DisplayBoard();
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
