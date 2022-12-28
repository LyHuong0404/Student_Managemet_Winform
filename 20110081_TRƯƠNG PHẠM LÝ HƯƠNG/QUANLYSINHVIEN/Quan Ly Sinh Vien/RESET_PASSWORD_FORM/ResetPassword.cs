using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Sinh_Vien
{
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }
        UserAccout userAccout = new UserAccout();
        private void buttonReset_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string pass = textBoxPass.Text;
            try
            {
                if(textBoxPass.Text.Trim() != "")
                {
                    if (userAccout.updateUser(username, pass))
                    {
                        MessageBox.Show("Your Password Updated Successfully!!", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Login_Form login_Form = new Login_Form();
                        Hide();
                        login_Form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Updated Fail", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter new password!!", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
