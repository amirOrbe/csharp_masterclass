using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Section_7;

namespace TicTacToeExercise
{
    class Program
    {
        static void main(string[] args)
        {

            Play();

            void PrintBoard(char[,] board)
            {
                Console.WriteLine(" {0} | {1} | {2} ", board[0, 0] == ' ' ? 1 : board[0, 0], board[0, 1] == ' ' ? 2 : board[0, 1], board[0, 2] == ' ' ? 3 : board[0, 2]);
                Console.WriteLine("---+---+---");
                Console.WriteLine(" {0} | {1} | {2} ", board[1, 0] == ' ' ? 4 : board[1, 1], board[1, 1] == ' ' ? 5 : board[1, 1], board[1, 2] == ' ' ? 6 : board[1, 2]);
                Console.WriteLine("---+---+---");
                Console.WriteLine(" {0} | {1} | {2} ", board[2, 0] == ' ' ? 7 : board[2, 0], board[2, 1] == ' ' ? 8 : board[2, 1], board[2, 2] == ' ' ? 9 : board[2, 2]);
            }

            void Play()
            {
                char currentPlayer = 'X';
                bool gameEnded = false;

                char[,] board = new char[3, 3]
                {
                    { ' ', ' ', ' ' },
                    { ' ', ' ', ' ' },
                    { ' ', ' ', ' ' }
                };

                while (!gameEnded)
                {
                    PrintBoard(board);

                    Console.WriteLine($"Player {currentPlayer}, enter a number between 1 and 9: ");

                    int cellNumber = int.Parse(Console.ReadLine());

                    int row = (cellNumber - 1) / 3;
                    int col = (cellNumber - 1) % 3;

                    if (board[row, col] == ' ')
                    {
                        
                        board[row, col] = (char)currentPlayer;

                        Console.WriteLine(board[row, col]);

                        if (CheckWin(board, currentPlayer))
                        {
                            Console.WriteLine($"Player {currentPlayer} wins!");
                            gameEnded = true;
                        }
                        else if (CheckTie(board))
                        {
                            Console.WriteLine("Tie game!");
                            gameEnded = true;
                        }
                        else
                        {
                            currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
                        }
                    }
                    else
                    {
                        Console.WriteLine("That cell is already occupied. Try again.");
                    }
                }

                PrintBoard(board);
            }

            bool CheckWin(char[,] board, char player)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player)
                    {
                        return true;
                    }
                }

                for (int j = 0; j < 3; j++)
                {
                    if (board[0, j] == player && board[1, j] == player && board[2, j] == player)
                    {
                        return true;
                    }
                }

                if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
                {
                    return true;
                }

                if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
                {
                    return true;
                }

                return false;
            }

            bool CheckTie(char[,] board)
            {
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(0); j++)
                    {
                        if (board[i, j] == ' ')
                        {
                            return false;
                        }
                    }
                }

                return true;
            }
        }
    }
}
