using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGameKnightMove
{
    public class ChessBoard
    {

        public ChessBoard()
        {

            ChessBoardHorizontalSymbol = "+-------";
            ChessBoardVerticalSymbol = "|   ";
            ChessBoardVerticalSymbolsp = "|    ";


        }

        public string ChessBoardHorizontalSymbol { get; set; }
        public string ChessBoardVerticalSymbol { get; set; }
        public string ChessBoardVerticalSymbolsp { get; set; }

        public static void intialeBoard()
        {
            Console.Write("      ");
            for (int i = 0; i < SetupBoard.Demtion; i++)
            {
                Console.Write("{0}       ", i); // x axis header
            }

            Console.WriteLine();
            for (int r = 0; r < SetupBoard.Demtion; r++)
            {
                Console.Write("  ");
                for (int c = 0; c < SetupBoard.Demtion; c++)
                {
                    Console.Write("+-------");
                }

                Console.Write("+\n");

                for (int c = 0; c < SetupBoard.Demtion; c++)
                {
                    if (c == 0)
                        Console.Write(r + " "); //y axis header

                    Console.Write("|   " + "    ");






                }

                Console.Write("|\n");
            }


            Console.Write("  "); //left spacing
            for (int c = 0; c < SetupBoard.Demtion; c++)
            {
                Console.Write("+-------");
            }


            Console.Write("+ \n\n \n ");


        }

        public void displayChessBoard()
        {

            Console.Write("      ");
            for (int i = 0; i < SetupBoard.Demtion; i++)
            {
                Console.Write("{0}       ", i); // x axis header
            }
            Console.WriteLine();
            for (int r = 0; r < SetupBoard.Demtion; r++)
            {
                Console.Write("  ");
                for (int c = 0; c < SetupBoard.Demtion; c++)
                {
                    Console.Write(ChessBoardHorizontalSymbol);
                }

                Console.Write("+\n");

                for (int c = 0; c < SetupBoard.Demtion; c++)
                {
                    if (c == 0)
                        Console.Write(r + " "); //y axis header

                    if (KnightPath.Valide[r, c] || Knight.knight_Pos[r, c] == "K ")
                    {

                        Console.Write(ChessBoardVerticalSymbol);
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write(Knight.knight_Pos[r, c] + "  ");

                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.Write(ChessBoardVerticalSymbol + "    ");
                    }





                }

                Console.Write("|\n");
            }


            Console.Write("  "); //left spacing
            for (int c = 0; c < SetupBoard.Demtion; c++)
            {
                Console.Write(ChessBoardHorizontalSymbol);
            }


            Console.Write("+ \n\n \n ");





        }




    }
}
