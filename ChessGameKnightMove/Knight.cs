using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGameKnightMove
{
    public class Knight : KnightPath
    {
        public static string M;
        public const String SPACE = "*****";
        public static String[,] knight_Pos;
        public static List<int> current_X, current_Y;
        public Knight()
        {

            Knight_Path();
        }

        public static void Knight_Path()
        {
            knight_Pos = new string[SetupBoard.Demtion, SetupBoard.Demtion];
            M = "K";
            bool[,] arrayValide = new bool[Demtion, Demtion];
            current_X = currentX;
            current_Y = currentY;
            knight_Pos[knightPosX, knightPosy] = M + " ";
            int count = 1;

            for (int i = 0; i < current_X.Count; i++)

            {
                M = Convert.ToString(count);
                if (M.Length == 2)
                {
                    knight_Pos[current_X[i], current_Y[i]] = String.Format("{0}", M);
                }
                else if (M.Length == 1)
                {
                    knight_Pos[current_X[i], current_Y[i]] = String.Format("{0} ", M);
                }
                count++;

            }


        }
    }
}
