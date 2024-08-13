using Bai1_GameCaro.Model;
using System;

namespace Bai1_GameCaro.Service
{
    public class CaroService
    {
        private int size;
        private Cell[,] board;
        private string currentPlayer;
        private int winningCount;

        public event Action<string> PlayerWon;

        public CaroService(int boardSize, int winningCount)
        {
            size = boardSize;
            this.winningCount = winningCount;
            board = new Cell[size, size];
            currentPlayer = "X";
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    board[i, j] = new Cell(i, j);
                }
            }
        }

        public string GetCurrentPlayer()
        {
            return currentPlayer;
        }

        public bool MakeMove(int row, int column)
        {
            if (board[row, column].Value == null)
            {
                board[row, column].Value = currentPlayer;

                if (CheckWin(row, column))
                {
                    PlayerWon?.Invoke(currentPlayer); // Trigger the event when player wins
                }
                else
                {
                    currentPlayer = currentPlayer == "X" ? "O" : "X";
                }

                return true;
            }
            return false;
        }

        public bool CheckFullBoard()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (board[i, j].Value == null)
                        return false;
                }
            }
            return true;
        }

        public bool CheckWin(int row, int column)
        {
            string player = board[row, column].Value;
            return CheckDirection(row, column, 1, 0, player) || // Horizontal
                   CheckDirection(row, column, 0, 1, player) || // Vertical
                   CheckDirection(row, column, 1, 1, player) || // Diagonal \
                   CheckDirection(row, column, 1, -1, player);  // Diagonal /
        }

        private bool CheckDirection(int row, int column, int dRow, int dColumn, string player)
        {
            int count = 1;

            // Check in one direction
            for (int i = 1; i < winningCount; i++)
            {
                int r = row + i * dRow;
                int c = column + i * dColumn;
                if (r >= 0 && r < size && c >= 0 && c < size && board[r, c].Value == player)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            // Check in the opposite direction
            for (int i = 1; i < winningCount; i++)
            {
                int r = row - i * dRow;
                int c = column - i * dColumn;
                if (r >= 0 && r < size && c >= 0 && c < size && board[r, c].Value == player)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count >= winningCount;
        }

        public int GetBoardSize()
        {
            return size;
        }
    }
}
