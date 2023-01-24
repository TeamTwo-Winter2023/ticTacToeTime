using System;

namespace ticTacToeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~Welcome to the game~~~");

            Supporting sup = new Supporting();
            char[,] gameBoard = { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };
            int turns = 0;

            sup.PrintBoard(gameBoard);
            
            while (turns < 9)
            {
                char marker;
                string input;
                if (turns % 2 == 0 )
                {
                    Console.WriteLine("\nGo player 1!");
                    marker = 'X';
                }
                else
                {
                    Console.WriteLine("\nGo player 2!");
                    marker = 'O';
                }

                Console.WriteLine("Where do you want to go? ex- 1,1");
                input = Console.ReadLine();
                
                string[] indexes = input.Split(",");
                bool rowSuccess = int.TryParse((indexes[0].Trim()), out int rowNumber);
                bool colSuccess = int.TryParse((indexes[1].Trim()), out int colNumber);

                //check if the input is integers
                if (rowSuccess == false || colSuccess == false)
                {
                    Console.WriteLine("You must input numbers!");
                    continue;
                }
                //check if in bounds
                if (rowNumber > 2 || rowNumber < 0 || colNumber > 2 || colNumber < 0)
                {
                    Console.WriteLine("That number is out of bounds!");
                    continue;
                }
                //check if that spot has already been taken
                if (gameBoard[rowNumber, colNumber] != '-')
                {
                    Console.WriteLine("Someone already went there!");
                    continue;
                }

                gameBoard[rowNumber, colNumber] = marker;                

                //call supporting function to print the board and see if there's a winner or not
                char Winner = sup.Winner(gameBoard);
                sup.PrintBoard(gameBoard);
                if (Winner == 'X')
                {
                    Console.WriteLine("\nPlayer 1 wins!");
                    break;
                }
                if (Winner == 'O')
                {
                    Console.WriteLine("\nPlayer 2 wins!");
                    break;
                }

                //if nobody won then increment the turns and either continue loop or end the game if the board is full
                turns++;

                if (turns == 9)
                {
                    Console.WriteLine("\nCat's Game! Nobody Wins this time");
                }
            }

        }
    }
}
