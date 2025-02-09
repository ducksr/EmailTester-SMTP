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
            label9 = new Label();
            label8 = new Label();
            btnReset = new Button();
            btnSendEmail = new Button();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtSubjectEmail = new TextBox();
            txtToEmail = new TextBox();
            txtFromEmail = new TextBox();
            txtSMTPPort = new TextBox();
            txtSMTPServer = new TextBox();
            txtMessageEmail = new TextBox();
            label6 = new Label();
            label7 = new Label();
            lblCountingChars = new Label();
            txtLog = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(btnSendEmail);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtSubjectEmail);
            panel1.Controls.Add(txtToEmail);
            panel1.Controls.Add(txtFromEmail);
            panel1.Controls.Add(txtSMTPPort);
            panel1.Controls.Add(txtSMTPServer);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(937, 269);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(793, 288);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 16;
            label9.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(618, 288);
            label8.Name = "label8";
            label8.Size = new Size(37, 20);
            label8.TabIndex = 16;
            label8.Text = "Log:";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(505, 34);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(115, 37);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSendEmail
            // 
            btnSendEmail.Location = new Point(505, 194);
            btnSendEmail.Name = "btnSendEmail";
            btnSendEmail.Size = new Size(115, 37);
            btnSendEmail.TabIndex = 12;
            btnSendEmail.Text = "Send-Test";
            btnSendEmail.UseVisualStyleBackColor = true;
            btnSendEmail.Click += btnSendEmail_Click;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 73);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 8;
            label2.Text = "SMTP Port:";
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
            // txtSubjectEmail
            // 
            txtSubjectEmail.Location = new Point(143, 204);
            txtSubjectEmail.MaxLength = 200;
            txtSubjectEmail.Name = "txtSubjectEmail";
            txtSubjectEmail.Size = new Size(318, 27);
            txtSubjectEmail.TabIndex = 6;
            txtSubjectEmail.Text = "Text-Email-Subject";
            // 
            // txtToEmail
            // 
            txtToEmail.Location = new Point(143, 159);
            txtToEmail.MaxLength = 200;
            txtToEmail.Name = "txtToEmail";
            txtToEmail.Size = new Size(318, 27);
            txtToEmail.TabIndex = 5;
            txtToEmail.Text = "address@Domain.com";
            // 
            // txtFromEmail
            // 
            txtFromEmail.Location = new Point(143, 114);
            txtFromEmail.MaxLength = 200;
            txtFromEmail.Name = "txtFromEmail";
            txtFromEmail.Size = new Size(318, 27);
            txtFromEmail.TabIndex = 4;
            txtFromEmail.Text = "NotReplay@YourDomain.com";
            // 
            // txtSMTPPort
            // 
            txtSMTPPort.Location = new Point(143, 70);
            txtSMTPPort.MaxLength = 200;
            txtSMTPPort.Name = "txtSMTPPort";
            txtSMTPPort.Size = new Size(318, 27);
            txtSMTPPort.TabIndex = 3;
            txtSMTPPort.Text = "25";
            // 
            // txtSMTPServer
            // 
            txtSMTPServer.Location = new Point(143, 27);
            txtSMTPServer.MaxLength = 200;
            txtSMTPServer.Name = "txtSMTPServer";
            txtSMTPServer.Size = new Size(318, 27);
            txtSMTPServer.TabIndex = 2;
            txtSMTPServer.Text = "192.168.1.100";
            // 
            // txtMessageEmail
            // 
            txtMessageEmail.Location = new Point(12, 323);
            txtMessageEmail.MaxLength = 250;
            txtMessageEmail.Multiline = true;
            txtMessageEmail.Name = "txtMessageEmail";
            txtMessageEmail.Size = new Size(579, 326);
            txtMessageEmail.TabIndex = 12;
            txtMessageEmail.Text = "Writte your Text.................";
            txtMessageEmail.KeyUp += txtMessageEmail_KeyUp;
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
            label7.Location = new Point(356, 300);
            label7.Name = "label7";
            label7.Size = new Size(117, 20);
            label7.TabIndex = 13;
            label7.Text = "Max  chars 250 /";
            // 
            // lblCountingChars
            // 
            lblCountingChars.AutoSize = true;
            lblCountingChars.Location = new Point(479, 300);
            lblCountingChars.Name = "lblCountingChars";
            lblCountingChars.Size = new Size(21, 20);
            lblCountingChars.TabIndex = 14;
            lblCountingChars.Text = "0 ";
            // 
            // txtLog
            // 
            txtLog.Enabled = false;
            txtLog.HideSelection = false;
            txtLog.Location = new Point(630, 323);
            txtLog.MaxLength = 37750;
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(319, 326);
            txtLog.TabIndex = 15;
            txtLog.Text = "Application Started....";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 661);
            Controls.Add(txtLog);
            Controls.Add(lblCountingChars);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtMessageEmail);
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
        private TextBox txtSubjectEmail;
        private TextBox txtToEmail;
        private TextBox txtFromEmail;
        private TextBox txtSMTPPort;
        private TextBox txtSMTPServer;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMessageEmail;
        private Label label6;
        private Label label7;
        private Label lblCountingChars;
        private Button btnReset;
        private Button btnSendEmail;
        private TextBox txtLog;
        private Label label8;
        private Label label9;
    }
}
