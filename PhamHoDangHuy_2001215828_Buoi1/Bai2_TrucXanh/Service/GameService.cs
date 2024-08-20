using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Bai2_TrucXanh.Service
{
    public static class GameService
    {
        public static Image LoadImage(string imageName)
        {
            string imagePath = Path.Combine(Application.StartupPath, "Images", imageName);
            if (!File.Exists(imagePath))
            {
                throw new FileNotFoundException($"Image '{imageName}' not found at path '{imagePath}'.");
            }
            return Image.FromFile(imagePath);
        }

        public static void CreateGrid(string pairCountText, Panel panelGrid)
        {
            if (!int.TryParse(pairCountText, out int pairCount) || pairCount <= 0)
            {
                MessageBox.Show("Vui lòng nhập số cặp hình hợp lệ.");
                return;
            }

            panelGrid.Controls.Clear();

            int columns = 5; // Number of images per row
            int rows = 4;    // Total number of rows
            int totalImages = pairCount * 2; // Total number of images

            // Ensure the number of images does not exceed the grid capacity
            totalImages = Math.Min(totalImages, columns * rows);

            int imageSize = 50; // Size of each PictureBox
            int padding = 5;    // Padding between PictureBoxes

            // Set up the grid structure
            panelGrid.AutoScroll = true;
            panelGrid.SuspendLayout(); // Suspend layout logic during bulk updates

            for (int i = 0; i < totalImages; i++)
            {
                PictureBox pictureBox = new PictureBox
                {
                    Width = imageSize,
                    Height = imageSize,
                    BorderStyle = BorderStyle.FixedSingle,
                    Image = LoadImage("theweeknd1.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                // Calculate row and column based on index
                int columnIndex = i % columns;
                int rowIndex = i / columns;

                // Set location with padding
                pictureBox.Location = new Point(columnIndex * (imageSize + padding), rowIndex * (imageSize + padding));

                // Add PictureBox to panel
                panelGrid.Controls.Add(pictureBox);
            }

            panelGrid.ResumeLayout(); 
        }

        public static void StartGame()
        {

        }
    }
}
