using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Sinh_Vien
{
    public partial class CourseStudentList : Form
    {
        public CourseStudentList()
        {
            InitializeComponent();
        }

        My_DB mydb = new My_DB();

        private void buttonShow_Click(object sender, EventArgs e)
        {
            string query = "SELECT DISTINCT Score.student_id as StudentID, std.fname as FirstName, std.lname as LastName" +
                                     " FROM (Course JOIN Score ON Course.Id = Score.course_id) " +
                                     " JOIN std ON Score.student_id = std.Id " +
                                     " WHERE Course.semester = @sem" +
                                     " AND Course.lable = @Cname";

            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            cmd.Parameters.Add("@sem", SqlDbType.Int).Value = comboBoxSemester.SelectedItem;
            cmd.Parameters.Add("Cname", SqlDbType.VarChar).Value = textBoxCourseName.Text;

            mydb.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            adapter.Fill(table);

           // dataGridView_information.Columns.Add();
            dataGridView_information.DataSource = table;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {

            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if (printDlg.ShowDialog() == DialogResult.OK)
                printDoc.Print();
        }
    }
}
