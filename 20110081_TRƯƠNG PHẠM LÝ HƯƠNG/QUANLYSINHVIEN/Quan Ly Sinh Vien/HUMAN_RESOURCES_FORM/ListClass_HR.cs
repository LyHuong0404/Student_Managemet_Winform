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
    public partial class ListClass_HR : Form
    {
        public ListClass_HR()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable table;
        Class_HR myclass = new Class_HR();

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            string query = "select Course.Id as CourseID, Course.lable as CourseName, MyClass.semester as Semester" +
                            " from Course join MyClass on Course.Id = MyClass.course_id and Course.semester = MyClass.semester " +
                            " join mycontact on MyClass.contact_id = mycontact.Id" +
                            " where mycontact.Id = @contactID and mycontact.userid = " + Globals.GlobalUserId +
                            " and CONCAT(Course.Id,Course.lable, MyClass.semester) LIKE '%" + textBoxSearch.Text + "%'";

            command = new SqlCommand(query, mydb.getConnection);
            command.Parameters.Add("@contactID", SqlDbType.Int).Value = Convert.ToInt32(labelContactID.Text);
            mydb.openConnection();
            adapter = new SqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);


            if (command.ExecuteNonQuery() !=  1)
            {
                dataGridViewClass.DataSource = table;
                mydb.closeConnection();

            }
            else
            {
                mydb.closeConnection();
                MessageBox.Show("Not Found", "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }


        private void dataGridViewClass_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StudenList_HR studenList_HR = new StudenList_HR();
            studenList_HR.labelCourseName.Text = dataGridViewClass.CurrentRow.Cells[1].Value.ToString();
            studenList_HR.labelContactID.Text = labelContactID.Text;
            studenList_HR.labelSemester.Text= dataGridViewClass.CurrentRow.Cells[2].Value.ToString();
            studenList_HR.labelContactName.Text = labelContactName.Text;
            studenList_HR.Show();
        }
    }
}
