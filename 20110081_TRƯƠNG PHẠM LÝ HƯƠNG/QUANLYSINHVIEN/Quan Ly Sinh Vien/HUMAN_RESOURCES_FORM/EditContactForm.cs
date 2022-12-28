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
    public partial class EditContactForm : Form
    {
        public EditContactForm()
        {
            InitializeComponent();
        }

        CONTACT contact = new CONTACT();
        My_DB mydb = new My_DB();
        Group group = new Group ();
        User user = new User();

        private void EditContactForm_Load(object sender, EventArgs e)
        {
            contact_id_cbb.DataSource = contact.selectContactByUserID(Globals.GlobalUserId);
            contact_id_cbb.DisplayMember = "Id";  //***************
            contact_id_cbb.ValueMember = "Id";
            contact_id_cbb.Text = "";

            comboBoxGroup.DataSource = group.getGroupByUserId(Globals.GlobalUserId); 
            comboBoxGroup.DisplayMember = "Id";
            comboBoxGroup.ValueMember = "Id";
            comboBoxGroup.Text = "";
        }

        private void UploadImage_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSelectContact_Click(object sender, EventArgs e)
        {
            string query = "Select Id, fname as FirstName, lname as LastName, group_id as GroupID, email as Email, " +
                " address as Address, phone as Phone, pic as Picture from mycontact where Id = @id and userid = " + Globals.GlobalUserId;

            SelectContact select_Contact_From = new SelectContact();   
            SqlCommand command = new SqlCommand(query, mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = contact_id_cbb.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);
            
            select_Contact_From.dataGridView1.DataSource = table;

            if (select_Contact_From.dataGridView1[0,0].Value == null)
            {
                MessageBox.Show("Don't Allow To See", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    textBoxFName.Text = select_Contact_From.dataGridView1.Rows[0].Cells[1].Value.ToString();
                    textboxLName.Text = select_Contact_From.dataGridView1.Rows[0].Cells[2].Value.ToString();
                    comboBoxGroup.Text = select_Contact_From.dataGridView1.Rows[0].Cells[3].Value.ToString();
                    textBoxEmail.Text = select_Contact_From.dataGridView1.Rows[0].Cells[4].Value.ToString();
                    TextboxAddress.Text = select_Contact_From.dataGridView1.Rows[0].Cells[5].Value.ToString();
                    textBoxPhone.Text = select_Contact_From.dataGridView1.Rows[0].Cells[6].Value.ToString();

                    byte[] pic = (byte[])select_Contact_From.dataGridView1.Rows[0].Cells[7].Value;
                    MemoryStream picture = new MemoryStream(pic);
                    PictureBoxImage.Image = Image.FromStream(picture);

                    DataGridViewImageColumn picol = new DataGridViewImageColumn();
                    picol = (DataGridViewImageColumn)select_Contact_From.dataGridView1.Columns[7];

                    picol.ImageLayout = DataGridViewImageCellLayout.Stretch;

                    select_Contact_From.dataGridView1.AllowUserToAddRows = false;

                    select_Contact_From.ShowDialog(this);
                }
                catch
                {
                    MessageBox.Show("Don't Allow To See", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
          
        }

        private void buttonEditContact_Click(object sender, EventArgs e)
        {
            string fname = textBoxFName.Text;
            string lname = textboxLName.Text;
            string phone = textBoxPhone.Text;
            string address = TextboxAddress.Text;
            string email = textBoxEmail.Text;

            try
            {
                int group_id = Convert.ToInt32(comboBoxGroup.Text);
                int contactid = Convert.ToInt32(contact_id_cbb.Text);
                MemoryStream pic = new MemoryStream();
                PictureBoxImage.Image.Save(pic, PictureBoxImage.Image.RawFormat);

                if (contact.updateContact(contactid, fname, lname, group_id, phone, email, address, pic))
                {
                    MessageBox.Show("Contact information Updated", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid ID", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Invalid ID", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
