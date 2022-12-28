using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Sinh_Vien
{
    public partial class VerifyOTP : Form
    {
        public VerifyOTP()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();
        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (textBoxOTP.Text != OTP.otp)
            {
                MessageBox.Show("Invalid OTP", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ResetPassword resetPassword = new ResetPassword();
                resetPassword.textBoxUsername.Text = textBoxUsername.Text;
                Hide();
                resetPassword.Show();
            }
        }
    }
}
