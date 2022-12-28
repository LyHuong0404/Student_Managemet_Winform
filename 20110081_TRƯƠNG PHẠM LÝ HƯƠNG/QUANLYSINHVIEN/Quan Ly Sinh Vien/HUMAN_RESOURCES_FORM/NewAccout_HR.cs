using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Sinh_Vien
{
    public partial class NewAccout_HR : Form
    {
        public NewAccout_HR()
        {
            InitializeComponent();
        }
        STUDENTS student = new STUDENTS();

        User user = new User();
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            string fname = textBoxFName.Text;
            string lname = textBoxLName.Text;
            string uname = textBoxUserName.Text;
            string pw = textBoxPassword.Text;
            MemoryStream pic = new MemoryStream();           
             
            if (user.checkHR(id,uname))
            {
                MessageBox.Show("Invalid Username", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                pictureBoxImage.Image.Save(pic, pictureBoxImage.Image.RawFormat);
                if (user.insertUser(id, fname, lname, uname, pw, pic))
                {
                    MessageBox.Show("New User Added", "Add USer",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add User",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_UploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void textBoxFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //chu
            if (!char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //chu
            if (!char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
