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
    public partial class Register_NewUser : Form
    {
        public Register_NewUser()
        {
            InitializeComponent();
        }

        STUDENTS student = new STUDENTS();

        SqlCommand command;

        DataTable table;

        private void bt_OK_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SELECT Id FROM log_in");

            table = new DataTable();

            UserAccout newUser = new UserAccout();

            table = student.getStudents(command);
            int id = table.Rows.Count;
            table.Clear();

            command = new SqlCommand("SELECT username FROM log_in WHERE username = @User");
            string username = tb_username.Text;
            string pw = tb_password.Text;

            command.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            

            table = student.getStudents(command);

 
            newUser.insertUser(id, username, pw);
            

            
            //sending mail to new user
            MailMessage mail = new MailMessage();
           
            mail.From = new MailAddress("lyhuong2002@gmail.com");
            mail.To.Add(tb_email.Text);
            mail.Subject = "Congratulation!!You signed up successfully.";
            mail.Body = "Congratulation to " + tb_email.Text + ".\n"
                             + "Your Username: " + tb_username.Text + ".\n"
                             + "Your Password: " + tb_password.Text + ".";
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("lyhuong2002@gmail.com", "hoquanghieu0402");
            smtp.EnableSsl = true;
            smtp.Send(mail);
    
            MessageBox.Show("Congratulation!! Added successfully!!", "Add User", MessageBoxButtons.OK);

        }


        private void tb_username_MouseLeave(object sender, EventArgs e)
        {
            command = new SqlCommand("SELECT username FROM log_in WHERE username = @User");
            string username = tb_username.Text;

            command.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            

            table = student.getStudents(command);


            if (table.Rows.Count > 0)   
            {
                MessageBox.Show(tb_username.Text + " already exists.Please use other username", "Error", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_username.Clear();
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void tb_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Down")
                tb_password.Focus();
        }

        private void tb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Up")
                tb_email.Focus();
        }

        private void tb_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Down")
                tb_password.Focus();
            else if (e.KeyCode.ToString() == "Up")
                tb_username.Focus();
        }
    }
}