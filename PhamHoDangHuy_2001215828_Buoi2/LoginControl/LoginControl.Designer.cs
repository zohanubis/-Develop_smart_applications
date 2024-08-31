namespace LoginControl
{
    partial class LoginControl
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

        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(150, 30);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(150, 70);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(150, 110);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 30);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(50, 30);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(78, 20);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(50, 70);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // LoginControl
            // 
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "LoginControl";
            Size = new Size(400, 180);
            Load += LoginControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
    }
}
