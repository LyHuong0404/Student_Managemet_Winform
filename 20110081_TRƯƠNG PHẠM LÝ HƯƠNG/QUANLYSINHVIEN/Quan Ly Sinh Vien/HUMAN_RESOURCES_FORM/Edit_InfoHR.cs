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
    public partial class Edit_InfoHR : Form
    {
        public Edit_InfoHR()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();

        User user = new User();
        private void buttonEdit_Click(object sender, EventArgs e)
        {
           
            int id = Convert.ToInt32(textBoxID.Text);
            string fname = textBoxFName.Text;
            string lname = textBoxLName.Text;
            string uname = textBoxUserName.Text;
            string pw = textBoxPassword.Text;
            MemoryStream pic = new MemoryStream();

            if (user.checkHRedit(id, uname))
            {
                MessageBox.Show("Invalid Accout!!", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                pictureBoxImage.Image.Save(pic, pictureBoxImage.Image.RawFormat);
                if (user.updateUser(id, fname, lname, uname, pw, pic))
                {
                    MessageBox.Show("User Edited Successfully", "Edit USer",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ContactAndGroup contactandgroup = new ContactAndGroup();
                    contactandgroup.labelWelcome.Text = "(" + textBoxUserName.Text.Replace(" ","") + ")";
                    contactandgroup.labelHRName.Text = textBoxFName.Text.Replace(" ", "") + " " + textBoxLName.Text.Replace(" ", "");

                    //**************************************************
                    byte[] pic1 = (byte[])pic.ToArray();
                     MemoryStream picture = new MemoryStream(pic1);
                     contactandgroup.pictureBoxHR.Image = Image.FromStream(picture);
                    Hide();
                    contactandgroup.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("Error", "Edit User",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void LoadOddInfo()
        {
            string query = "select * from HR where Id = " + Globals.GlobalUserId;

            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            textBoxID.Text = table.Rows[0][0].ToString();
            textBoxFName.Text = table.Rows[0][1].ToString();
            textBoxLName.Text = table.Rows[0][2].ToString();
            textBoxUserName.Text = table.Rows[0][3].ToString();
            textBoxPassword.Text = table.Rows[0][4].ToString();

            byte[] pic = (byte[])table.Rows[0][5];
            MemoryStream picture = new MemoryStream(pic);
            pictureBoxImage.Image = Image.FromStream(picture);
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
