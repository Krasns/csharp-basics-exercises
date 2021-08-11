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
            int row ,column;
            int count = 0;
            int winner = 0;
            string location;
            while (count != 9)
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
                            }
                            if (board[0, 0] == 'O' && (board[0, 0] == board[0, 1]) && (board[0, 1] == board[0, 2]))
                            {
                                winner = 1;
                                count = 8;
                            }
                            else if (board[1, 0] == 'O' && (board[1, 0] == board[1, 1]) && (board[1, 1] == board[1, 2]))
                            {
                                winner = 1;
                                count = 8;
                            }
                            else if (board[2, 0] == 'O' && (board[2, 0] == board[2, 1]) && (board[2, 1] == board[2, 2]))
                            {
                                winner = 1;
                                count = 8;
                            }
                            else if (board[0, 0] == 'O' && (board[0, 0] == board[1, 0]) && (board[1, 0] == board[2, 0]))
                            {
                                winner = 1;
                                count = 8;
                            }
                            else if (board[0, 1] == 'O' && (board[0, 1] == board[1, 1]) && (board[1, 1] == board[1, 2]))
                            {
                                winner = 1;
                                count = 8;
                            }
                            else if (board[0, 2] == 'O' && (board[0, 2] == board[1, 2]) && (board[1, 2] == board[2, 2]))
                            {
                                winner = 1;
                                count = 8;
                            }
                            else if (board[0, 0] == 'O' && (board[0, 0] == board[1, 1]) && (board[1, 1] == board[2, 2]))
                            {
                                winner = 1;
                                count = 8;
                            }
                            else if (board[0, 2] == 'O' && (board[0, 2] == board[1, 1]) && (board[1, 1] == board[2, 0]))
                            {
                                winner = 1;
                                count = 8;
                            }
                        }
                    }
                    if (winner ==1)
                    {
                        Console.WriteLine("  O wins!");
                        Console.WriteLine();
                        DisplayBoard();
                        Console.ReadKey();
                    }
                    else
                    {
                        DisplayBoard();
                        player = 1;
                    }
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
                            }
                            if (board[0, 0] == 'X' && (board[0, 0] == board[0, 1]) && (board[0, 1] == board[0, 2]))
                            {
                                winner = 1;
                                count = 8;
                            }
                            else if (board[1, 0] == 'X' && (board[1, 0] == board[1, 1]) && (board[1, 1] == board[1, 2]))
                            {
                                winner = 1;
                                count = 8;
                            }
                            else if (board[2, 0] == 'X' && (board[2, 0] == board[2, 1]) && (board[2, 1] == board[2, 2]))
                            {
                                winner = 1;
                                count = 8;
                            }
                            else if (board[0, 0] == 'X' && (board[0, 0] == board[1, 0]) && (board[1, 0] == board[2, 0]))
                            {
                                winner = 1;
                                count = 8;
                            }
                            else if (board[0, 1] == 'X' && (board[0, 1] == board[1, 1]) && (board[1, 1] == board[1, 2]))
                            {
                                winner = 1;
                                count = 8;
                            }
                            else if (board[0, 2] == 'X' && (board[0, 2] == board[1, 2]) && (board[1, 2] == board[2, 2]))
                            {
                                winner = 1;
                                count = 8;
                            }
                            else if (board[0, 0] == 'X' && (board[0, 0] == board[1, 1]) && (board[1, 1] == board[2, 2]))
                            {
                                winner = 1;
                                count = 8;
                            }
                            else if (board[0, 2] == 'X' && (board[0, 2] == board[1, 1]) && (board[1, 1] == board[2, 0]))
                            {
                                winner = 1;
                                count = 8;
                            }
                        }
                    }

                    if (winner == 1)
                    {
                        Console.WriteLine("  X wins!");
                        Console.WriteLine();
                        DisplayBoard();
                        Console.ReadKey();
                    }
                    else
                    {
                        DisplayBoard();
                        player = 0;
                    }
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
        }
    }
}
