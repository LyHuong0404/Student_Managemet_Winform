using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Sinh_Vien
{
    public partial class ContactAndGroup : Form
    {
        public ContactAndGroup()
        {
            InitializeComponent();
        }

        My_DB mydb = new My_DB();
        Group gr = new Group();
        CONTACT contact = new CONTACT();
        User user = new User();

        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            AddContactForm addContactForm = new AddContactForm();
            addContactForm.Show();
        }

        private void buttonEditContact_Click(object sender, EventArgs e)
        {

            EditContactForm edit_Contact_Form = new EditContactForm();
            edit_Contact_Form.Show();
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            int id_new = Convert.ToInt32(textBoxIDNewGroup.Text);

            string name_new = textBoxAddNameGroup.Text;

            if (textBoxAddNameGroup.Text.Trim() != "" || textBoxIDNewGroup.Text.Trim() != "")
            {
                try
                {
                    if (gr.groupExist(name_new, "add", Globals.GlobalUserId, id_new))
                    {
                        if (gr.insertGroup(id_new, name_new, Globals.GlobalUserId))
                        {
                            MessageBox.Show("New Group Added", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBoxAddNameGroup.Text = "";
                            textBoxIDNewGroup.Text = "";
                            LoadDaTa();
                        }
                        else
                        {
                            MessageBox.Show("Error", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Group are already existed", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch
                {
                    MessageBox.Show("Group are already existed", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Enter Group!!", "Add group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
            }
            LoadDaTa();
        }

        public void LoadDaTa()
        {
            contact_id_cbb.DataSource = contact.selectContactByUserID(Globals.GlobalUserId);
            contact_id_cbb.DisplayMember = "Id";
            contact_id_cbb.ValueMember = "Id";
            contact_id_cbb.Text = "";

            comboBoxEditGroup.DataSource = gr.getGroupByUserId(Globals.GlobalUserId);
            comboBoxEditGroup.DisplayMember = "name";
            comboBoxEditGroup.ValueMember = "Id";
            comboBoxEditGroup.Text = "";

            comboBoxRemoveGroup.DataSource = gr.getGroupByUserId(Globals.GlobalUserId);
            comboBoxRemoveGroup.DisplayMember = "name";
            comboBoxRemoveGroup.ValueMember = "Id";
            comboBoxRemoveGroup.Text = "";
        }

        private void ContactAndGroup_Load(object sender, EventArgs e)
        {
            LoadDaTa();
            Edit_InfoHR edit_InfoHR = new Edit_InfoHR();
            edit_InfoHR.LoadOddInfo();
        }

        private void buttonEditGroup_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBoxEditGroup.SelectedValue.ToString());
            string GrName = textBoxEnterNewName.Text;

            if (textBoxEnterNewName.Text.Trim() != "")
            {
                try
                {
                    if (gr.groupExist(GrName, "edit", Globals.GlobalUserId, id))
                    {
                        if (gr.updateGroup(id, GrName))
                        {
                            MessageBox.Show("Updated Group Successfully!!", "Update Group",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            comboBoxEditGroup.Text = "";
                            textBoxEnterNewName.Text = "";
                            LoadDaTa();
                        }
                        else
                        {
                            MessageBox.Show("Error", "Update Group",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Group are already existed", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch
                {
                    MessageBox.Show("Group are already existed", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Enter value into Group Name!!");
            }
        }

        private void buttonRemoveGroup_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBoxRemoveGroup.SelectedValue.ToString());

            if (gr.deleteGroup(id))
            {              
                MessageBox.Show("Deleted Group Successfully!!", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDaTa();
            }
            else
            {
                MessageBox.Show("Error", "Update Group",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonRemoveContact_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(contact_id_cbb.SelectedValue.ToString());
            if (contact.deleteContact(id))
            {
                MessageBox.Show("Deleted Contact Successfully!!", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);                
                LoadDaTa();
            }
            else
            {
                MessageBox.Show("Error", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSelectContact_Click(object sender, EventArgs e)
        {
            string query = "Select Id, fname as FirstName, lname as LastName, group_id as GroupID " +
                           " from mycontact where Id = @id";

            SelectContact select_Contact_From = new SelectContact(); SqlCommand command = new SqlCommand(query, mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = contact_id_cbb.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            select_Contact_From.dataGridView1.DataSource = table;
            select_Contact_From.ShowDialog(this);
        }

        private void buttonShowFullList_Click(object sender, EventArgs e)
        {
            ContactFullListForm contactFullList = new ContactFullListForm();
            contactFullList.Show();
        }

        private void buttonAddClass_Click(object sender, EventArgs e)
        {
            AddClass_HR addClass_HR = new AddClass_HR();
            addClass_HR.ShowDialog();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            contact_id_cbb.DataSource = contact.selectContactByUserID(Globals.GlobalUserId);
            contact_id_cbb.DisplayMember = "Id";
            contact_id_cbb.ValueMember = "Id";
            contact_id_cbb.Text = "";
        }

        private void labelEdit_Click(object sender, EventArgs e)
        {
            Edit_InfoHR edit_InfoHR = new Edit_InfoHR();
            edit_InfoHR.LoadOddInfo();
            Hide();
            edit_InfoHR.ShowDialog();

        }

        private void labelLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to log out?", "Log Out", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void textBoxIDNewGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            //so
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxAddNameGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            //chu
            if (!char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxEnterNewName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //chu
            if (!char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
