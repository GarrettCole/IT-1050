using System;
using IO = System.Console;

namespace Project_5
{
    class Program
    {
        private const int size = 8;
        private static string[][] board;

        private static void Main(string[] args)
        {
            bool finished = false;
            int startX;
            int startY;
            int destX;
            int destY;

            MakeBoard();

            while (!finished)
            {
                Print();

                IO.WriteLine("To exit the game, put 0 for all coordinates");
                IO.WriteLine();

                IO.Write("Pick X coordinate starting point : ");
                startX = int.Parse(IO.ReadLine());

                IO.Write("Pick Y coordinate starting point : ");
                startY = int.Parse(IO.ReadLine());

                IO.Write("Pick X coordinate end point : ");
                destX = int.Parse(IO.ReadLine());

                IO.Write("Pick Y coordinate end point : ");
                destY = int.Parse(IO.ReadLine());

                if (startX == 0)
                {
                    if (startY == 0)
                    {
                        if (destX == 0)
                        {
                            if (destY == 0)
                            {
                                finished = true;
                            }

                        }
                    }
                }

                IO.WriteLine("Press any key to continue");
                IO.ReadLine();
                IO.Clear();

                if (startX < 0 | startX > 7)
                {
                    finished = true;
                }

                if (startY < 0 | startY > 7)
                {
                    finished = true;
                }

                if (destX < 0 | destX > 7)
                {
                    finished = true;
                }

                if (destY < 0 | destY > 7)
                {
                    finished = true;
                }

                if (board[startX][startY] == "X")
                {
                    board[destX][destY] = "X";
                    board[startX][startY] = " ";
                }

            }

        }

        static void MakeBoard()
        {
            board = new string[size][];

            for (int i = 0; i < size; i++)
            {
                board[i] = new string[size];

                for (int j = 0; j < size; j++)
                {                    
                    board[i][j] = (i < 2 || i > 5) ? "X" : " ";
                }
            }
        }

        static void Print()
        {
            PrintLine();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {                  
                    IO.Write(" | " + board[i][j]);
                }

                IO.Write(" |");
                IO.WriteLine();
                PrintLine();
            }
        }

        static void PrintLine()
        {                  
            IO.WriteLine(" +-------------------------------+");
        }
    }
    
}
