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
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }

        My_DB mydb = new My_DB();
        Group mygroup = new Group();
        CONTACT contact = new CONTACT();
        User user = new User();

        private void UploadImage_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            gr_cbb.DataSource = mygroup.getGroupByUserId(Globals.GlobalUserId);           
            gr_cbb.DisplayMember = "name";
            gr_cbb.ValueMember = "Id";
            gr_cbb.Text = "";
        }

        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxContactID.Text);
            int userid = Globals.GlobalUserId;  
            string fname = textBoxFName.Text;
            string lname = textboxLName.Text;
            string phone = textBoxPhone.Text;
            string email = textBoxEmail.Text;
            string address = TextboxAddress.Text;
            int groupid = Convert.ToInt32(gr_cbb.SelectedValue.ToString());
            MemoryStream pic = new MemoryStream();


            if (verify())
            {
                try
                {

                    if (contact.checkContactID(id))
                    {
                        PictureBoxImage.Image.Save(pic, PictureBoxImage.Image.RawFormat);

                        if (contact.insertContact(id, fname, lname, phone, address, email, userid, groupid, pic))
                        {
                            MessageBox.Show("New Contact Added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("ERROR", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Contact ID", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid ID", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Value Empty!!", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool verify()
        {
            if ((textBoxContactID.Text.Trim() == "")
                || (textBoxFName.Text.Trim() == "")
                || (textboxLName.Text.Trim() == "")
                || (TextboxAddress.Text.Trim() == "")
                || (textBoxEmail.Text.Trim() == "")
                || (textBoxPhone.Text.Trim() == "")
                || (PictureBoxImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxContactID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContactID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //so
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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

        private void textboxLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //chu
            if (!char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void TextboxAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            //so
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
