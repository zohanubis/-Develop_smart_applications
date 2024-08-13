namespace Bai1_GameCaro.App
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtBoardSize;
        private System.Windows.Forms.Label lblBoardSize;
        private System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.NumericUpDown numWinningCount;
        public System.Windows.Forms.Label lblWinningCount;
        public System.Windows.Forms.ProgressBar progressBar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtBoardSize = new TextBox();
            lblBoardSize = new Label();
            btnStart = new Button();
            numWinningCount = new NumericUpDown();
            lblWinningCount = new Label();
            progressBar = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)numWinningCount).BeginInit();
            SuspendLayout();
            // 
            // txtBoardSize
            // 
            txtBoardSize.Location = new Point(140, 23);
            txtBoardSize.Margin = new Padding(4, 3, 4, 3);
            txtBoardSize.Name = "txtBoardSize";
            txtBoardSize.Size = new Size(116, 23);
            txtBoardSize.TabIndex = 0;
            // 
            // lblBoardSize
            // 
            lblBoardSize.AutoSize = true;
            lblBoardSize.Location = new Point(23, 27);
            lblBoardSize.Margin = new Padding(4, 0, 4, 0);
            lblBoardSize.Name = "lblBoardSize";
            lblBoardSize.Size = new Size(98, 15);
            lblBoardSize.TabIndex = 1;
            lblBoardSize.Text = "Board Size (1-50):";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(140, 69);
            btnStart.Margin = new Padding(4, 3, 4, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(117, 27);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start Game";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // numWinningCount
            // 
            numWinningCount.Location = new Point(140, 110);
            numWinningCount.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numWinningCount.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numWinningCount.Name = "numWinningCount";
            numWinningCount.Size = new Size(116, 23);
            numWinningCount.TabIndex = 3;
            numWinningCount.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblWinningCount
            // 
            lblWinningCount.AutoSize = true;
            lblWinningCount.Location = new Point(13, 113);
            lblWinningCount.Name = "lblWinningCount";
            lblWinningCount.Size = new Size(125, 15);
            lblWinningCount.TabIndex = 4;
            lblWinningCount.Text = "Winning Count (3-10):";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(20, 190);
            progressBar.Margin = new Padding(4, 3, 4, 3);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(360, 23);
            progressBar.TabIndex = 5;
            progressBar.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 300);
            Controls.Add(progressBar);
            Controls.Add(lblWinningCount);
            Controls.Add(numWinningCount);
            Controls.Add(btnStart);
            Controls.Add(lblBoardSize);
            Controls.Add(txtBoardSize);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caro Game";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)numWinningCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
