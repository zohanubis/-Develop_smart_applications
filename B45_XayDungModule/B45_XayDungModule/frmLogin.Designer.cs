namespace B45_XayDungModule
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginControl = new LoginControl.LoginControl();
            this.SuspendLayout();
            // 
            // loginControl
            // 
            this.loginControl.Cnn = null;
            this.loginControl.Location = new System.Drawing.Point(12, 12);
            this.loginControl.Name = "loginControl";
            this.loginControl.Size = new System.Drawing.Size(350, 150);
            this.loginControl.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 170);
            this.Controls.Add(this.loginControl);
            this.Name = "frmLogin";
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);

        }

        #endregion

        private LoginControl.LoginControl loginControl;
    }
}

