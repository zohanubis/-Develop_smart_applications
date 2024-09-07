namespace PhamHoDangHuy_Buoi2_ConnectionDatabase.GUI
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
            this.loginControl1 = new LoginControl.LoginControl();
            this.studentInfoControl1 = new StudentInfo.StudentInfoControl();
            this.SuspendLayout();
            // 
            // loginControl1
            // 
            this.loginControl1.Location = new System.Drawing.Point(12, 12);
            this.loginControl1.Name = "loginControl1";
            this.loginControl1.Size = new System.Drawing.Size(400, 180);
            this.loginControl1.TabIndex = 0;
            // 
            // studentInfoControl1
            // 
            this.studentInfoControl1.Cnn = null;
            this.studentInfoControl1.Location = new System.Drawing.Point(12, 171);
            this.studentInfoControl1.Name = "studentInfoControl1";
            this.studentInfoControl1.Size = new System.Drawing.Size(400, 246);
            this.studentInfoControl1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 429);
            this.Controls.Add(this.studentInfoControl1);
            this.Controls.Add(this.loginControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private LoginControl.LoginControl loginControl1;
        private StudentInfo.StudentInfoControl studentInfoControl1;
    }
}