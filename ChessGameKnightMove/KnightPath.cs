using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGameKnightMove
{
    public class KnightPath : SetupBoard
    {
        //const int N = 8;
        static int Cx, Cy;
        public static List<int> currentX, currentY;
        public static bool[,] Valide;
        public static bool solution;


        readonly static int[,] moves = { {+1,-2},{+2,-1},{+2,+1},{+1,+2},
                                     {-1,+2},{-2,+1},{-2,-1},{-1,-2} };
        struct ListMoves
        {
            public int x, y;
            public ListMoves(int _x, int _y) { x = _x; y = _y; }
        }




        public static void knightPath()
        {
            solution = true;
            int[,] board = new int[Demtion, Demtion];
            currentX = new List<int>();
            currentY = new List<int>();
            Valide = new bool[Demtion, Demtion];
            board.Initialize();


            int x = knightPosX,                      // starting position
                y = knightPosy;

            int pathx = destinationX,
                pathY = destinationY;
            for (int i = 0; i < Demtion; i++)
            {
                for (int j = 0; j < Demtion; j++)
                {
                    Valide[i, j] = false;
                }

            }
            List<ListMoves> list = new List<ListMoves>(Demtion * Demtion);
            list.Add(new ListMoves(x, y));

            do
            {

                if (Move_Possible(board, x, y))
                {
                    int move = board[x, y];
                    board[x, y]++;
                    x += moves[move, 0];
                    y += moves[move, 1];
                    currentX.Add(x);
                    currentY.Add(y);
                    Valide[x, y] = true;
                    list.Add(new ListMoves(x, y));

                }
                else
                {
                    if (board[x, y] >= 8)
                    {
                        board[x, y] = 0;
                        list.RemoveAt(list.Count - 1);
                        if (list.Count == 0)
                        {
                            Console.WriteLine("No solution found.");
                            solution = false;
                            return;
                        }
                        x = list[list.Count - 1].x;
                        y = list[list.Count - 1].y;
                        currentX.Add(x);
                        currentY.Add(y);
                        Valide[x, y] = true;
                    }
                    board[x, y]++;
                }

            }

            while (!Test_Position(currentX, currentY, pathx, pathY));


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("DONE : \n");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("> 0 :(" + knightPosy + " " + knightPosX + ") ");

            for (int i = 0; i < currentX.Count; i++)
            {
                int path = i + 1;
                Console.Write(" --> " + path + " :(" + currentY[i] + " " + currentX[i] + ") ");
            }
            Console.WriteLine(" \n ");
        }

        static bool Move_Possible(int[,] board, int cur_x, int cur_y)
        {
            if (board[cur_x, cur_y] >= Demtion)
                return false;

            int new_x = cur_x + moves[board[cur_x, cur_y], 0],
                new_y = cur_y + moves[board[cur_x, cur_y], 1];

            if (new_x >= 0 && new_x < Demtion && new_y >= 0 && new_y < Demtion && board[new_x, new_y] == 0)
                return true;

            return false;
        }

        static bool Test_Position(List<int> currentx, List<int> currenty, int pathX, int pathY)
        {

            foreach (var item in currentx)
            {
                Cx = item;
            }
            foreach (var item in currenty)
            {
                Cy = item;
            }
            if ((Cx == pathX) && (Cy == pathY))
                return true;
            else
                return false;



        }
    }
}

