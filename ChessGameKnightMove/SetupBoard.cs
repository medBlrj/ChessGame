using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace ChessGameKnightMove
{
    public class SetupBoard
    {
        public static int Demtion;
        public static int knightPosX;
        public static int knightPosy;
        public static int destinationX;
        public static int destinationY;
        public static int DIMENSION;
        public static int[] knightPos;
        public static int[] targetPos;
        public bool Exit { get; set; }
        public static string input;


        KnightPath path;
        public SetupBoard()
        {
            input = "";
            knightPosX = 0;
            knightPosy = 0;
            destinationX = 0;
            destinationY = 0;
            knightPos = new int[] { knightPosX, knightPosy };
            targetPos = new int[] { destinationX, destinationY };
            Exit = false;
            Demtion = 2;


        }



        public static void SetUp()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine("\n");

            Console.WriteLine(" ============================================================================== " +
                "\n    ________  __________________    _________    __  _________ \n " +
                "  / ____/ / / / ____/ ___/ ___/   / ____/   |  /  |/  / ____/ \n" +
                @"  / /   / /_/ / __/  \__ \\__ \   / / __/ /| | / /|_/ / __/  " +
                "\n / /___/ __  / /___ ___/ /__/ /  / /_/ / ___ |/ /  / / /___   \n" +
                @" \____/_/ /_/_____//____/____/   \____/_/  |_/_/  /_/_____/" +
                "                                                             " +

                "\n =============================================================================");

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.Write("\n Hi! User   ");

            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            do
            {

                Console.Write("\n Please enter Chess board d 0 - 15  , or type Q to quit \n ==> ");
                input = Console.ReadLine();
                if (!input.ToUpper().Equals("Q"))
                {
                    int number = 0;
                    if (int.TryParse(input, out number))
                    {
                        if (number >= 0 && number <= 15)
                        {
                            Demtion = number;
                            ChessBoard.intialeBoard();
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("ERROR :");
                            Console.ResetColor();
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine(" Invalid input. \n  ");
                        }

                      
                    }

                   
                }
                else {
                    Console.WriteLine("bayy");
                    Environment.Exit(0);
                }
                    

            }
            while (!input.ToUpper().Equals("Q"));
            






        }



        public void MakeMove()
        {


            Console.WriteLine("\nDonne \n ");
            path = new KnightPath();
            KnightPath.knightPath();


        }

        public void getInput()
        {

            Console.WriteLine("Enter Knight's X axis position ");
            Exit = validateInput(int.TryParse(Console.ReadLine(), out knightPosy));


            if (!Exit) //if we passed the previous validation, move to the next coordinates
            {
                Console.WriteLine("Enter Knight's Y axis position");
                Exit = validateInput(int.TryParse(Console.ReadLine(), out knightPosX));

            }

            if (!Exit) //if we passed the previous validation, move to the next coordinates
            {
                Console.WriteLine("Enter Destination's X axis");
                Exit = validateInput(int.TryParse(Console.ReadLine(), out destinationY));

            }

            if (!Exit) //if we passed the previous validation, move to the next coordinates
            {
                Console.WriteLine("Enter Destination's Y axis");
                Exit = validateInput(int.TryParse(Console.ReadLine(), out destinationX));


            }


        }

        private bool validateInput(bool parsed)
        {
            bool error = false;


            if (!parsed)
            {
                error = true;

            }
            if (!parsed)
                error = true;
            else if (knightPosX < 0 || knightPosy < 0 || destinationX < 0 || destinationY < 0)
                error = true;
            else if (knightPosX > Demtion - 1 || knightPosy > Demtion - 1 ||
                      destinationX > Demtion - 1 || destinationY > Demtion - 1)
                error = true;


            if (error)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("ERROR :");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(" Invalid input. \n  ");


                knightPosX = 0;
                knightPosy = 0;
                destinationX = 0;
                destinationY = 0;
                getInput();
            }


            return error;
        }



    }
}
