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
using Word = Microsoft.Office.Interop.Word;

namespace Quan_Ly_Sinh_Vien
{
    public partial class StudenList_HR : Form
    {
        public StudenList_HR()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable table;
        Class_HR myclass = new Class_HR();
        private void StudenList_HR_Load(object sender, EventArgs e)
        {
            string query = "select std.Id as StudentID, std.fname as FirstName, std.lname as LastName, Q.Student_Score, Q.semester as Semester, std.picture as Picture" +
                           " from std join (Select distinct std.Id as StudentID, std.fname as FirstName, std.lname as LastName, Score.student_score as Student_Score, Score.semester as Semester" +
                           " from (Course join MyClass on Course.Id = MyClass.course_id and Course.semester = MyClass.semester) " +
                           " join (Score join std on Score.student_id = std.Id) on std.Id = Score.student_id and Course.Id = Score.course_id and Course.semester = Score.semester" +
                           " where MyClass.contact_id = @cid and MyClass.semester = @sem and Course.lable = @cname) as Q on std.Id = Q.StudentID ";

            command = new SqlCommand(query, mydb.getConnection);
            command.Parameters.Add("@sem", SqlDbType.Int).Value = Convert.ToInt32(labelSemester.Text);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = Convert.ToInt32(labelContactID.Text);
            command.Parameters.Add("@cname", SqlDbType.NChar).Value = labelCourseName.Text;
            adapter = new SqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);

      
            DataGridViewImageColumn picol = new DataGridViewImageColumn();
            dataGridViewListStudent.RowTemplate.Height = 80;
            dataGridViewListStudent.DataSource = table;
            picol = (DataGridViewImageColumn)dataGridViewListStudent.Columns[5];
            picol.ImageLayout = DataGridViewImageCellLayout.Stretch;

        }

    }
}
