using System;
using ChessGameKnightMove;

namespace ChessGame
{

    public class Program

    {
        public static int Demtion;

        static void Main(string[] args)


        {
            
            ChessBoard ChessBoard = new ChessBoard();
            SetupBoard Board = new SetupBoard();

            SetupBoard.SetUp();
            Board.getInput();
            KnightPath.knightPath();


            Knight.Knight_Path();
            ChessBoard.displayChessBoard();
            Console.ReadLine();
            Console.WriteLine("");

        }
    }



}