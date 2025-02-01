namespace Email_Tester_SMTP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(937, 269);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(318, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(318, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(143, 159);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(318, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(143, 114);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(318, 27);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(143, 204);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(318, 27);
            textBox5.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 34);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 7;
            label1.Text = "SMTP Server:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 73);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 8;
            label2.Text = "SMTP Port:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 162);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 10;
            label3.Text = "To:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 117);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 9;
            label4.Text = "From:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 207);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 11;
            label5.Text = "Subject:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 323);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(937, 326);
            textBox6.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 300);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 12;
            label6.Text = "Message Text:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(723, 300);
            label7.Name = "label7";
            label7.Size = new Size(117, 20);
            label7.TabIndex = 13;
            label7.Text = "Max  chars 250 /";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(846, 300);
            label8.Name = "label8";
            label8.Size = new Size(21, 20);
            label8.TabIndex = 14;
            label8.Text = "0 ";
            // 
            // button1
            // 
            button1.Location = new Point(505, 207);
            button1.Name = "button1";
            button1.Size = new Size(115, 37);
            button1.TabIndex = 12;
            button1.Text = "Send-Test";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(505, 34);
            button2.Name = "button2";
            button2.Size = new Size(115, 37);
            button2.TabIndex = 13;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 661);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(panel1);
            MaximumSize = new Size(979, 708);
            MinimumSize = new Size(979, 708);
            Name = "Form1";
            Text = "Email Tester SMTP";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button2;
        private Button button1;
    }
}
