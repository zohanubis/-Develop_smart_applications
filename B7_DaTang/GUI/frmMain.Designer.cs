namespace GUI
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLyDiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyMonHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyDiemToolStripMenuItem,
            this.quanLyMonHocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLyDiemToolStripMenuItem
            // 
            this.quanLyDiemToolStripMenuItem.Name = "quanLyDiemToolStripMenuItem";
            this.quanLyDiemToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.quanLyDiemToolStripMenuItem.Text = "Quản Lý Điểm";
            this.quanLyDiemToolStripMenuItem.Click += new System.EventHandler(this.quanLyDiemToolStripMenuItem_Click);
            // 
            // quanLyMonHocToolStripMenuItem
            // 
            this.quanLyMonHocToolStripMenuItem.Name = "quanLyMonHocToolStripMenuItem";
            this.quanLyMonHocToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.quanLyMonHocToolStripMenuItem.Text = "Quản Lý Môn Học";
            this.quanLyMonHocToolStripMenuItem.Click += new System.EventHandler(this.quanLyMonHocToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Hệ Thống Quản Lý";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLyDiemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyMonHocToolStripMenuItem;
    }
}
