using Bai1_GameCaro.App;
using Bai1_GameCaro.Service;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai1_GameCaro.Controller
{
    internal class CaroController
    {
        private CaroService caroService;
        private MainForm form;
        private const int CellSize = 30;

        public CaroController(MainForm form)
        {
            this.form = form;
        }

        public void InitializeGame(int boardSize)
        {
            form.progressBar.Visible = true;

            int winningCount = (int)form.numWinningCount.Value;
            caroService = new CaroService(boardSize, winningCount);
            caroService.PlayerWon += OnPlayerWon;
            form.Controls.Clear();
            AdjustFormSize(boardSize);
            DrawBoard(boardSize);

        }

        private void AdjustFormSize(int boardSize)
        {
            int totalWidth = boardSize * CellSize;
            int totalHeight = boardSize * CellSize;


            form.MinimumSize = new Size(totalWidth + 40, totalHeight + 150);
            form.ClientSize = new Size(totalWidth + 40, totalHeight + 150);
        }

        private void DrawBoard(int boardSize)
        {
            int xOffset = 20; // Padding
            int yOffset = 20; // Padding

            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    Button button = new Button
                    {
                        Width = CellSize,
                        Height = CellSize,
                        Top = yOffset + i * CellSize,
                        Left = xOffset + j * CellSize,
                        Tag = new Tuple<int, int>(i, j)
                    };
                    button.Click += OnCellClick;
                    form.Controls.Add(button);
                }
            }

            form.progressBar.Maximum = boardSize * boardSize;
            form.progressBar.Value = 0;
        }

        private void OnCellClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            var position = (Tuple<int, int>)button.Tag;
            if (caroService.MakeMove(position.Item1, position.Item2))
            {
                button.Text = caroService.GetCurrentPlayer() == "X" ? "O" : "X";
                form.progressBar.Value++;

                if (caroService.CheckFullBoard())
                {
                    MessageBox.Show("Board is full. Resetting the board.");
                    InitializeGame(caroService.GetBoardSize()); 
                }
            }
        }

        private void OnPlayerWon(string player)
        {
            MessageBox.Show($"{player} wins!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            form.Controls.Clear();
            form.progressBar.Visible = false; 
        }
    }
}
