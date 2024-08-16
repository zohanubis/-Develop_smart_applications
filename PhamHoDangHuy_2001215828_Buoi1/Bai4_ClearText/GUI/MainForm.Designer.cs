namespace Bai4_ClearText.GUI
{
    partial class MainForm
    {
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnProcessTextBoxes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonPanel1 = new System.Windows.Forms.RadioButton();
            this.radioButtonPanel2 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();

            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;

            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;

            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;

            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 90);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;

            // 
            // btnProcessTextBoxes
            // 
            this.btnProcessTextBoxes.Location = new System.Drawing.Point(12, 183);
            this.btnProcessTextBoxes.Name = "btnProcessTextBoxes";
            this.btnProcessTextBoxes.Size = new System.Drawing.Size(150, 23);
            this.btnProcessTextBoxes.TabIndex = 4;
            this.btnProcessTextBoxes.Text = "Process Text Boxes";
            this.btnProcessTextBoxes.UseVisualStyleBackColor = true;
            this.btnProcessTextBoxes.Click += new System.EventHandler(this.btnProcessTextBoxes_Click);

            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 120);
            this.panel1.TabIndex = 5;

            // 
            // panel2
            // 
            this.panel2.Controls.Add(new System.Windows.Forms.TextBox() { Location = new System.Drawing.Point(12, 12), Name = "textBox5", Size = new System.Drawing.Size(100, 20) });
            this.panel2.Controls.Add(new System.Windows.Forms.TextBox() { Location = new System.Drawing.Point(12, 38), Name = "textBox6", Size = new System.Drawing.Size(100, 20) });
            this.panel2.Controls.Add(new System.Windows.Forms.TextBox() { Location = new System.Drawing.Point(12, 64), Name = "textBox7", Size = new System.Drawing.Size(100, 20) });
            this.panel2.Controls.Add(new System.Windows.Forms.TextBox() { Location = new System.Drawing.Point(12, 90), Name = "textBox8", Size = new System.Drawing.Size(100, 20) });
            this.panel2.Location = new System.Drawing.Point(220, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 120);
            this.panel2.TabIndex = 6;

            // 
            // radioButtonPanel1
            // 
            this.radioButtonPanel1.AutoSize = true;
            this.radioButtonPanel1.Location = new System.Drawing.Point(12, 138);
            this.radioButtonPanel1.Name = "radioButtonPanel1";
            this.radioButtonPanel1.Size = new System.Drawing.Size(67, 17);
            this.radioButtonPanel1.TabIndex = 7;
            this.radioButtonPanel1.TabStop = true;
            this.radioButtonPanel1.Text = "Panel 1";
            this.radioButtonPanel1.UseVisualStyleBackColor = true;

            // 
            // radioButtonPanel2
            // 
            this.radioButtonPanel2.AutoSize = true;
            this.radioButtonPanel2.Location = new System.Drawing.Point(12, 161);
            this.radioButtonPanel2.Name = "radioButtonPanel2";
            this.radioButtonPanel2.Size = new System.Drawing.Size(67, 17);
            this.radioButtonPanel2.TabIndex = 8;
            this.radioButtonPanel2.TabStop = true;
            this.radioButtonPanel2.Text = "Panel 2";
            this.radioButtonPanel2.UseVisualStyleBackColor = true;

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(440, 230);
            this.Controls.Add(this.radioButtonPanel1);
            this.Controls.Add(this.radioButtonPanel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnProcessTextBoxes);
            this.Name = "MainForm";
            this.Text = "Clear TextBox Example";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnProcessTextBoxes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonPanel1;
        private System.Windows.Forms.RadioButton radioButtonPanel2;
    }
}
