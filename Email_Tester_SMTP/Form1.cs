using Microsoft.VisualBasic;
using System.Net.Mail;

namespace Email_Tester_SMTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblCountingChars.Text = txtMessageEmail.TextLength.ToString();

            txtMessageEmail.ScrollBars = ScrollBars.Vertical;
            txtLog.ScrollBars = ScrollBars.Vertical;


        }

        private void txtMessageEmail_KeyUp(object sender, KeyEventArgs e)
        {
            lblCountingChars.Text = txtMessageEmail.TextLength.ToString();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            try {

                string from = txtFromEmail.Text.Trim();
                string to = txtToEmail.Text.Trim();

                string subject = txtSubjectEmail.Text.Trim() == "" ? "Test Email By Default" : txtSubjectEmail.Text.Trim();
                string body = txtMessageEmail.Text.Trim() == "" ? "Default Body Text": txtMessageEmail.Text.Trim();

                string SMTPServer = txtSMTPServer.Text.Trim();
                string SMTPPort = txtSMTPPort.Text.Trim() == "" || Information.IsNumeric(txtSMTPPort.Text.Trim()) == false ? "25" : txtSMTPPort.Text.Trim() ;


                if (from=="" || to=="" || SMTPServer=="") {
                    txtLog.Text = "The 'FROM','TO','SMTPServer','SMTPPort' those can not be empty!";
                }

                using MailMessage mailMessage = new MailMessage(from,to,subject,body);

                using SmtpClient smtpClient = new SmtpClient(SMTPServer,int.Parse(SMTPPort));

                smtpClient.SendCompleted += new SendCompletedEventHandler(SmtpClient_SendCompleted);

                smtpClient.SendMailAsync(mailMessage);


            }catch(Exception ex) {
                txtLog.Text = ex.Message;
            }
        }

        private void SmtpClient_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            txtLog.Text = e.Error.Message;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeComponent();
        }
    }
}
