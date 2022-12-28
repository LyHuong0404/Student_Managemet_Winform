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
    public partial class AddClass_HR : Form
    {
        public AddClass_HR()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable table;
        Class_HR myclass = new Class_HR();
    
        public void LoadClass()
        {
            string query = "select MyClass.contact_id as ContactID, Course.Id as CourseID, Course.lable as CourseName, MyClass.semester" +
                            " from Course join MyClass on Course.Id = MyClass.course_id and Course.semester = MyClass.semester " +
                            " join mycontact on MyClass.contact_id = mycontact.Id" +
                            " where mycontact.userid = " + Globals.GlobalUserId;

            command = new SqlCommand(query, mydb.getConnection);
            adapter = new SqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);

            dataGridViewClass.DataSource = table;
        }
        public void LoadContactID()
        {
            string query = "select Id" +
                           " from mycontact" +
                           " where userid = " + Globals.GlobalUserId;

            command = new SqlCommand(query, mydb.getConnection);
            adapter = new SqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);

            comboBoxContactID.DataSource = table;
            comboBoxContactID.DisplayMember = "Id";
            comboBoxContactID.ValueMember = "Id";
        }
        private void AddClass_HR_Load(object sender, EventArgs e)
        {
            LoadContactID();
            LoadClass();
   
            comboBoxSemester.Text = "";
            comboBoxContactID.Text = "";
        }

        private void buttonAddClass_Click(object sender, EventArgs e)
        {
            try
            {
                int contactID = Convert.ToInt32(comboBoxContactID.Text);
                string cid = comboSelectCourse.Text;
                int sem = Convert.ToInt32(comboBoxSemester.Text);
                if (comboBoxSemester.Text.Trim() != "" || comboSelectCourse.Text != "")
                {
                    if (myclass.checkClassExist(cid, sem))
                    {
                        if (myclass.insertClass(contactID, cid, sem))
                        {
                            MessageBox.Show("Class Added Successfully!!", "Add Class", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadClass();
                        }
                        else
                        {
                            MessageBox.Show("Error", "Add Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Class are already existed!!", "Add Class", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter!!", "Add Class", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Class are already existed!!", "Add Class", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void comboBoxSemester_SelectedValueChanged(object sender, EventArgs e)
        {
            string query = "select distinct Id from Course where semester = @sem";
            command = new SqlCommand(query, mydb.getConnection);
            command.Parameters.Add("@sem", SqlDbType.Int).Value = Convert.ToInt32(comboBoxSemester.Text);
            adapter = new SqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);

            comboSelectCourse.DataSource = table;
            comboSelectCourse.DisplayMember = "Id";
            comboSelectCourse.ValueMember = "Id";
            //comboSelectCourse.Text = "";
        }
    }
}
