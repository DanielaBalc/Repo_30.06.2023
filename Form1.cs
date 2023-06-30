using System.Security.Cryptography;
using System.Text;
using System.Timers;
using Timer = System.Threading.Timer;

namespace Chalenge_BT_code_Crafte_app
{
    public partial class Form1 : Form
    {
        bool generate = false;
        int ticks = 0;
        public Form1()
        {
            InitializeComponent();
            dateTime.Text = DateTime.Now.ToString();
            timer_tb.Text = "Timer: " + ticks.ToString();
        }

        private void dateTime_TextChanged(object sender, EventArgs e)
        {

        }

        public string GenerateToken()
        {
            Random random = new Random();
            int length = random.Next(8, 16) - 4;
            using (RNGCryptoServiceProvider cryptRNG = new RNGCryptoServiceProvider())
            {
                byte[] tokenBuffer = new byte[length];
                cryptRNG.GetBytes(tokenBuffer);
                object token = Convert.ToBase64String(tokenBuffer);
                return token.ToString();
            }
        }
        private void generateBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(user_id.Text))
            {
                if (!timer1.Enabled)
                {
                    passwordTb.Text = GenerateToken();
                    passwordTb.UseSystemPasswordChar = true;
                    lb_error.Visible = false;
                    timer1.Enabled = true;
                    generateBtn.Enabled = false;
                    timer1_Tick(sender, e);
                }
                else
                {
                    generateBtn.Enabled = true;
                    timer1.Enabled = false;
                    lb_error.Visible = true;
                    lb_error.Text = "Password has expired";
                    generate = false;

                }
            }

            else
            {
                MessageBox.Show("The User ID is empty");
            }

        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            passwordTb.UseSystemPasswordChar = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            ticks++;
            timer_tb.Text = "Timer: " + ticks.ToString();
            if (ticks == 30)
            {
                generateBtn.Enabled = true;
                timer1.Enabled = false;
                lb_error.Visible = true;
                lb_error.Text = "Password has expired";
                generate = false;
                ticks = 0;
            }
        }
    }
}