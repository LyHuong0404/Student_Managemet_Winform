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
    public partial class AddCourseFrm : Form
    {
        public AddCourseFrm()
        {
            InitializeComponent();
        }

        STUDENT_SCORE stdScore = new STUDENT_SCORE();
        COURSES course = new COURSES();
        My_DB mydb = new My_DB();
        void showData()
        {
            int semester = Convert.ToInt32(comboBoxSemester.Text);
        
            listBoxAvailableCourse.DataSource = course.getCourseBySemester(semester);
            listBoxAvailableCourse.ValueMember = "Id";
            listBoxAvailableCourse.DisplayMember = "lable";
        }
       

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Score(student_id, course_id, student_score, description, semester)" +
                           " VALUES (@sid, @cid, @score, @des, @se)";
                SqlCommand cmd = new SqlCommand(query, mydb.getConnection);

                cmd.Parameters.Add("@sid", SqlDbType.Int).Value = Convert.ToInt32(textBoxStudentID.Text);
                cmd.Parameters.Add("@cid", SqlDbType.Char).Value = listBoxAvailableCourse.SelectedValue.ToString();
                cmd.Parameters.Add("@score", SqlDbType.Float).Value = 0;
                cmd.Parameters.Add("@des", SqlDbType.Text).Value = "NONE";
                cmd.Parameters.Add("@se", SqlDbType.Int).Value = Convert.ToInt32(comboBoxSemester.Text);

                mydb.openConnection();
                cmd.ExecuteNonQuery();
                mydb.closeConnection();

                //add vào list current
                int studentID = Convert.ToInt32(textBoxStudentID.Text);
                int semester = Convert.ToInt32(comboBoxSemester.Text);
                dataGridView_CurrentCoursesRegistered.DataSource = course.getStudentCoursesByStdID(studentID, semester);
            }
            catch
            {
                MessageBox.Show("This Course Name Already Registerd", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure want to save?", "Save Course", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Save successfully!!", "Save Course");
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            int studentID = Convert.ToInt32(textBoxStudentID.Text);
            int semester = Convert.ToInt32(comboBoxSemester.Text);
            showData();
            dataGridView_CurrentCoursesRegistered.DataSource = course.getStudentCoursesByStdID(studentID, semester);
        }

        private void AddCourseFrm_Load(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updateDeleteStudentF = new UpdateDeleteStudentForm();
            textBoxStudentID.Text = updateDeleteStudentF.tb_studentid.Text;
        }

        private void textBoxStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
