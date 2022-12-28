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
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            Hide();
            login_Form.Show();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            VerifyOTP verifyOTP = new VerifyOTP();

            string TempPass = "123ab";
            Random random = new Random();
            int randomCharIndex = 0;
            char randomChar;
            string captcha = "";
            for (int i = 0; i < 6; i++)
            {
                randomCharIndex = random.Next(0, TempPass.Length);
                randomChar = TempPass[randomCharIndex];
                captcha += Convert.ToString(randomChar);
            }

            OTP.otp = captcha;

            
            ForgetPassword forgetPassword = new ForgetPassword();
            OTP.gmail = forgetPassword.textBoxEmail.Text;

            //sending mail to new user
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("lyhuong2002@gmail.com");
            mail.To.Add(textBoxEmail.Text);
            mail.Subject = "RESET YOUR PASSWORD.";
            mail.Body = "Your OTP is: " + OTP.otp + ".\n";
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("lyhuong2002@gmail.com", "hoquanghieu0402");
            smtp.EnableSsl = true;
            smtp.Send(mail);

            verifyOTP.labelEmail.Text = textBoxEmail.Text;
            Hide();
            verifyOTP.Show();
        }
    }
}
