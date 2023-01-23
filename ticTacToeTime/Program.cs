using System;

namespace ticTacToeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game");
            
            Supporting sup = new Supporting();
            char[][] tic = new char[3][3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tic[i][j] = 'r'
                }
            }
            sup.PrintBoard(tic);
        }
    }
}
