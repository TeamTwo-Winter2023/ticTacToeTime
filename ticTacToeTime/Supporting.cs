using System;
using System.Collections.Generic;
using System.Text;

namespace ticTacToeTime
{    
    public class Supporting
    {
        // method to print board
        public void PrintBoard(char[,] boardArray)
        {
            Console.WriteLine("\t1   2   3");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1\t" + boardArray[0,0] + " | " + boardArray[0,1] + " | " + boardArray[0,2]);
            Console.WriteLine("\t---------");
            Console.WriteLine("2\t" + boardArray[1,0] + " | " + boardArray[1,1] + " | " + boardArray[1,2]);
            Console.WriteLine("\t---------");
            Console.WriteLine("3\t" + boardArray[2,0] + " | " + boardArray[2,1] + " | " + boardArray[2,2]);
        }

        // method to return winner
        public char Winner(char[,] boardArray)
        {
            char winningTeam = ' ';
            // horizontal check
            if ((boardArray[0,1] == boardArray[0, 2]) && (boardArray[0, 0] == boardArray[0, 2]))
            {
                winningTeam = boardArray[0, 0];
            }
            else if ((boardArray[1, 1] == boardArray[1, 2]) && (boardArray[1, 0] == boardArray[1, 2]))
            {
                winningTeam = boardArray[1, 0];
            }
            else if ((boardArray[2, 1] == boardArray[2, 2]) && (boardArray[2, 0] == boardArray[2, 2]))
            {
                winningTeam = boardArray[2, 0];
            }

            // vertical check
            else if ((boardArray[0, 0] == boardArray[1, 0]) && (boardArray[0, 0] == boardArray[2, 0]))
            {
                winningTeam = boardArray[0, 0];
            }
            else if ((boardArray[1, 0] == boardArray[1, 1]) && (boardArray[1, 0] == boardArray[1, 2]))
            {
                winningTeam = boardArray[1, 0];
            }
            else if ((boardArray[2, 0] == boardArray[2, 1]) && (boardArray[2, 0] == boardArray[2, 2]))
            {
                winningTeam = boardArray[2, 0];
            }

            // diagonal check
            else if ((boardArray[0, 0] == boardArray[1, 1]) && (boardArray[0, 0] == boardArray[2, 2]))
            {
                winningTeam = boardArray[0, 0];
            }
            else if ((boardArray[0, 2] == boardArray[1, 1]) && (boardArray[0, 2] == boardArray[2, 0]))
            {
                winningTeam = boardArray[0, 2];
            }

            // return if & who the winning team was
            return winningTeam;
        }
    }
}

