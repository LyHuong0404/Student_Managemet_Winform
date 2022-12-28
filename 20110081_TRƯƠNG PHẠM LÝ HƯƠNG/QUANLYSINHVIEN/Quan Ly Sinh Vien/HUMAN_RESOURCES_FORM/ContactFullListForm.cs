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
    public partial class ContactFullListForm : Form
    {
        public ContactFullListForm()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();
        User user = new User();
        Group group = new Group();
        CONTACT contact = new CONTACT();
        private void ContactFullListForm_Load(object sender, EventArgs e)
        {
            listBoxGroup.DataSource = group.getGroupByUserId(Globals.GlobalUserId);
            listBoxGroup.DisplayMember = "name";
            listBoxGroup.ValueMember = "Id";
            listBoxGroup.SelectedItem = null;

            dataGridViewContact.ReadOnly = true;

            DataGridViewImageColumn picol = new DataGridViewImageColumn();

            dataGridViewContact.RowTemplate.Height = 80;

            string query = "select mycontact.Id as ContactID, fname as FirstName,  lname as LastName, MyGroup.name as GroupName, phone as Phone, email as Email, address as Address, pic as Picture" +
                            " from mycontact join MyGroup on mycontact.group_id = MyGroup.Id " +
                            " where mycontact.userid = " + Globals.GlobalUserId;

            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);

            dataGridViewContact.DataSource = contact.selectContactList(cmd);

            picol = (DataGridViewImageColumn)dataGridViewContact.Columns[7];

            picol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridViewContact.AllowUserToAddRows = false;
        }
        
        private void listBoxGroup_Click(object sender, EventArgs e)
        {
            try
            {
                int groupid = Convert.ToInt32(listBoxGroup.SelectedValue);

                string query = "select mycontact.Id as ContactID, fname as FirstName,  lname as LastName, MyGroup.name as GroupName, phone as Phone, email as Email, address as Address, pic as Picture" +
                                " from mycontact join MyGroup on mycontact.group_id = MyGroup.Id " +
                                " where mycontact.userid = " + Globals.GlobalUserId + " and mycontact.group_id = @groupid";

                SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
                cmd.Parameters.Add("@groupid", SqlDbType.Int).Value = groupid;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewContact.DataSource = table;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridViewContact.ClearSelection();
        }

        private void dataGridViewContact_Click(object sender, EventArgs e)
        {
            textBoxAdd.Text = dataGridViewContact.CurrentRow.Cells[5].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ContactFullListForm_Load(null, null);
        }

        private void dataGridViewContact_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ListClass_HR listClass_HR = new ListClass_HR();

            string query = "select Course.Id as CourseID, Course.lable as CourseName, MyClass.semester" +
                            " from Course join MyClass on Course.Id = MyClass.course_id and Course.semester = MyClass.semester " +
                            " join mycontact on MyClass.contact_id = mycontact.Id" +
                            " where mycontact.Id = @contactID and mycontact.userid = " + Globals.GlobalUserId;

            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            command.Parameters.Add("@contactID", SqlDbType.Int).Value = Convert.ToInt32(dataGridViewContact.CurrentRow.Cells[0].Value);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            listClass_HR.dataGridViewClass.DataSource = table;
            listClass_HR.labelContactID.Text = dataGridViewContact.CurrentRow.Cells[0].Value.ToString();
            listClass_HR.labelContactName.Text = "Contact Name: " + dataGridViewContact.CurrentRow.Cells[2].Value.ToString().Replace(" ", "") + " " + dataGridViewContact.CurrentRow.Cells[1].Value.ToString().Replace(" ", "");
            listClass_HR.ShowDialog();
        }
    }
}
