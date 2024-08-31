namespace MainForm
{
    partial class MainForm
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
            loginControl1 = new LoginControl.LoginControl();
            studentInfoControl1 = new StudentInfoControl.StudentInfoControl();
            SuspendLayout();
            // 
            // loginControl1
            // 
            loginControl1.Location = new Point(12, 13);
            loginControl1.Margin = new Padding(3, 4, 3, 4);
            loginControl1.Name = "loginControl1";
            loginControl1.Size = new Size(400, 225);
            loginControl1.TabIndex = 0;
            // 
            // studentInfoControl1
            // 
            studentInfoControl1.Location = new Point(12, 164);
            studentInfoControl1.Margin = new Padding(4, 5, 4, 5);
            studentInfoControl1.Name = "studentInfoControl1";
            studentInfoControl1.Size = new Size(500, 375);
            studentInfoControl1.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 521);
            Controls.Add(studentInfoControl1);
            Controls.Add(loginControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Main Form";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private LoginControl.LoginControl loginControl1;
        private StudentInfoControl.StudentInfoControl studentInfoControl1;
    }
}