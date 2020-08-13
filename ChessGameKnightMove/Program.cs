using System;
using ChessGameKnightMove;

namespace ChessGame
{

    public class Program

    {
        public static int Demtion;
        public static bool Solution;
        static void Main(string[] args)


        {

            ChessBoard ChessBoard = new ChessBoard();
            SetupBoard Board = new SetupBoard();

            SetupBoard.SetUp();
            Board.getInput();
            KnightPath.knightPath();


            Solution = KnightPath.solution;
            if (Solution)
            {
                Knight.KnightMove();

                ChessBoard.displayChessBoard();

                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("try it agin");
            }

        }
    }



}

