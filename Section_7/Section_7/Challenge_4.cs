﻿using System;

namespace Section_7
{
    public class TicTacToe
    {
        public static bool Checker(string[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    return true;
                }
            }

            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] == board[1, j] && board[1, j] == board[2, j])
                {
                    return true;
                }
            }

            if ((board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2]) ||
                (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0]))
            {
                return true;
            }

            return false;
        }
    }
}
