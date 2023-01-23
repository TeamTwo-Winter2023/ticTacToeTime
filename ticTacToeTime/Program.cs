using System;

namespace ticTacToeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game");
            Supporting sup = new Supporting();

            char[,] gameBoard = { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };

         

            int turns = 0;
            while (turns < 9)
            {
                char marker;
                string input;
                if (turns % 2 == 0 )
                {
                    Console.WriteLine("Go player 1!");
                    marker = 'X';
                }
                else
                {
                    Console.WriteLine("Go player 2!");
                    marker = 'O';
                }

                Console.WriteLine("Where do you want to go? ex-1,1 ");
                input = Console.ReadLine();

                
                int rowNumber;
                int colNumber;
                string[] indexes = input.Split(",");
                bool rowSuccess = int.TryParse((indexes[0].Trim()), out rowNumber);
                bool colSuccess = int.TryParse((indexes[1].Trim()), out colNumber);

                //check if the input is integers
                if (rowSuccess == false || colSuccess == false)
                {
                    continue;
                }

                //check if that spot has already been taken

                if (gameBoard[rowNumber, colNumber] != '-')
                {
                    Console.WriteLine("Pick a different spot");
                    continue;
                }

                gameBoard[rowNumber, colNumber] = marker;

                sup.PrintBoard(gameBoard);

                turns++;

                //for (int i = 0; i < 3; i++)
                //{
                //    for (int j = 0; j < 3; j++)
                //    {
                //        Console.Write(gameBoard[i, j]);
                //    }
                //    Console.Write("\n");
                //}

            }

        }
    }
}
