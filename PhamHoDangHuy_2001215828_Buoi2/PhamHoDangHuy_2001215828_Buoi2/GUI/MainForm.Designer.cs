namespace PhamHoDangHuy_2001215828_Buoi2.GUI
{

        partial class MainForm
        {
            // Các thành phần của Form
            private System.Windows.Forms.StatusBar statusBar1;
            private System.Windows.Forms.MainMenu mainMenu1;
            private System.Windows.Forms.MenuItem menuItemFile;
            private System.Windows.Forms.MenuItem menuItemNew;
            private System.Windows.Forms.MenuItem menuItemEdit;

            // Phương thức để khởi tạo các thành phần
            private void InitializeComponent()
            {
            this.components = new System.ComponentModel.Container();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItemFile = new System.Windows.Forms.MenuItem();
            this.menuItemNew = new System.Windows.Forms.MenuItem();
            this.menuItemEdit = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 428);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(800, 22);
            this.statusBar1.TabIndex = 0;
            this.statusBar1.Text = "Xin chào người dùng";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFile,
            this.menuItemNew,
            this.menuItemEdit});
            // 
            // menuItemFile
            // 
            this.menuItemFile.Index = 0;
            this.menuItemFile.Text = "File";
            // 
            // menuItemNew
            // 
            this.menuItemNew.Index = 1;
            this.menuItemNew.Text = "New";
            // 
            // menuItemEdit
            // 
            this.menuItemEdit.Index = 2;
            this.menuItemEdit.Text = "Edit";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusBar1);
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

            }

            private System.ComponentModel.IContainer components;
        }
    

}