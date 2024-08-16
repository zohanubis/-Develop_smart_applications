using Bai2_TrucXanh.Service;

namespace Bai2_TrucXanh.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreateGrid_Click(object sender, EventArgs e)
        {
            // Call the service to create the grid
            GameService.CreateGrid(txtPairCount.Text, panelGrid);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Call the service to start the game
            GameService.StartGame();
        }
    }
}
