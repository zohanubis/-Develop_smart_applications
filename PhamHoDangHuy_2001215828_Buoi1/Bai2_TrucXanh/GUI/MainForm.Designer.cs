namespace Bai2_TrucXanh.GUI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            txtPairCount = new TextBox();
            btnCreateGrid = new Button();
            btnStart = new Button();
            panelGrid = new Panel();
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // txtPairCount
            // 
            txtPairCount.Location = new Point(12, 12);
            txtPairCount.Name = "txtPairCount";
            txtPairCount.Size = new Size(100, 27);
            txtPairCount.TabIndex = 0;
            // 
            // btnCreateGrid
            // 
            btnCreateGrid.Location = new Point(118, 10);
            btnCreateGrid.Name = "btnCreateGrid";
            btnCreateGrid.Size = new Size(75, 29);
            btnCreateGrid.TabIndex = 1;
            btnCreateGrid.Text = "Tạo Hình";
            btnCreateGrid.UseVisualStyleBackColor = true;
            btnCreateGrid.Click += btnCreateGrid_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(199, 10);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(90, 29);
            btnStart.TabIndex = 2;
            btnStart.Text = "Bắt đầu";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // panelGrid
            // 
            panelGrid.AutoScroll = true;
            panelGrid.Location = new Point(12, 61);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(655, 400);
            panelGrid.TabIndex = 3;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 467);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(655, 23);
            progressBar.TabIndex = 4;
            // 
            // MainForm
            // 
            ClientSize = new Size(679, 515);
            Controls.Add(progressBar);
            Controls.Add(panelGrid);
            Controls.Add(btnStart);
            Controls.Add(btnCreateGrid);
            Controls.Add(txtPairCount);
            Name = "MainForm";
            Text = "Game Trúc Xanh";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtPairCount;
        private System.Windows.Forms.Button btnCreateGrid;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}
