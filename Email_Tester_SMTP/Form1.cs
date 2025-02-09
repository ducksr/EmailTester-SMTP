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

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitializeComponent();
        }
    }
}
