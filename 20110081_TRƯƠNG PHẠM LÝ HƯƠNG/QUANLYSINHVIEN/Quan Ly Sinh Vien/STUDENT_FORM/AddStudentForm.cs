using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Sinh_Vien
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                STUDENTS student = new STUDENTS();
                int id = Convert.ToInt32(tb_studenid.Text);
                string fname = tb_fname.Text;
                string lname = tb_lname.Text;
                DateTime bdate = dateTimePicker1.Value;
                string phone = tb_phone.Text;
                string adr = tb_address.Text;
                string gender = "Male";

                if (radioButtoon_Female.Checked)
                {
                    gender = "Female";
                }

                MemoryStream pic = new MemoryStream();
                int born_year = dateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;

                //sv tu 10-100, co the thay doi
                if (((this_year - born_year) < 10 || ((this_year - born_year) > 100)))
                {
                    MessageBox.Show("The Student Age Must Be 10 and 100 year", "Invalid Birth Date",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                    if (student.insertStudent(id, fname, lname, bdate, gender, phone, adr, pic))
                    {
                        MessageBox.Show("New Student Added", "Add Student",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Student",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Add Student",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Invalid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //chuc nang kiem tra du lieu input
        bool verif()
        {
            if ((tb_fname.Text.Trim() == "")
                || (tb_lname.Text.Trim() =="")
                || (tb_address.Text.Trim() == "")
                || (tb_phone.Text.Trim() == "")
                || (pictureBox1.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_UploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif|*.jpg;*.png;*.gif";
            if((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        //only enter number
        private void tb_studenid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // //only enter number
        private void tb_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            //chu
            if (!char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tb_lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tb_studenid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Down")
            {
                tb_fname.Focus();
            }
        }

        private void tb_fname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Down")
            {
                tb_lname.Focus();
            }
            else if (e.KeyCode.ToString() == "Up")
            {
                tb_studenid.Focus();
            }
        }

        private void tb_lname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Down")
            {
                dateTimePicker1.Focus();
            }
        }

        private void tb_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Up")
            {
                tb_phone.Focus();
            }
        }

        private void tb_phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Up")
            {
                tb_address.Focus();
            }
        }
    }
}
