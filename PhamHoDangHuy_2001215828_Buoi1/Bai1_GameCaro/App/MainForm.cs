using Bai1_GameCaro.Controller;
using System;
using System.Windows.Forms;

namespace Bai1_GameCaro.App
{
    public partial class MainForm : Form
    {
        private CaroController caroController;

        public MainForm()
        {
            InitializeComponent();
            caroController = new CaroController(this);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int size;
            if (int.TryParse(txtBoardSize.Text, out size))
            {
                if (size > 0 && size <= 50)
                {
                    caroController.InitializeGame(size);
                }
                else
                {
                    MessageBox.Show("Invalid board size. Please enter a size between 1 and 50.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}
