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
    public partial class ManageScoreForm : Form
    {
        public ManageScoreForm()
        {
            InitializeComponent();
        }

        STUDENT_SCORE score = new STUDENT_SCORE();
        STUDENTS student = new STUDENTS();
        COURSES course = new COURSES();
        My_DB mydb = new My_DB();


        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            dataGridView_infomation.DataSource = score.getStudentsScore();

            comboSelectCourse.DisplayMember = "lable";
            comboSelectCourse.ValueMember = "Id";
        }

        private void buttonShowScore_Click(object sender, EventArgs e)
        {

            dataGridView_infomation.DataSource = score.getStudentsScore();
        }

        private void dataGridView_infomation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxStudentID.Text = dataGridView_infomation.CurrentRow.Cells[0].Value.ToString();           
        }

        private void buttonAverage_Click(object sender, EventArgs e)
        {
            AVGScoreByCourseForm avgScore = new AVGScoreByCourseForm();
            avgScore.Show(this);
        }

        private void buttonShowStudent_Click(object sender, EventArgs e)
        {
            string query = "SELECT Id as StudentID, fname as FirstName, lname as LastName, bdate as Birthdate FROM std";

            SqlCommand cmd = new SqlCommand(query); 

            dataGridView_infomation.DataSource = student.getStudents(cmd);
        }

        private void comboBoxSemester_SelectedValueChanged(object sender, EventArgs e)
        {
            int studentID = Convert.ToInt32(textBoxStudentID.Text);
            int semester = Convert.ToInt32(comboBoxSemester.Text);

            comboSelectCourse.DataSource = course.getStudentCoursesByStdID(studentID, semester);
            comboSelectCourse.ValueMember = "Id";
            comboSelectCourse.DisplayMember = "lable";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(textBoxStudentID.Text);
                string courseID = (string)comboSelectCourse.SelectedValue;
                float scorevalue = Convert.ToInt32(textBoxScore.Text);
                string description = textBoxDescription.Text;
                int semester = Convert.ToInt32(comboBoxSemester.Text);


                if (!score.studentScoreExist(studentID, courseID))
                {
                    if (score.insertScore(studentID, courseID, scorevalue, description, semester))
                    {
                        MessageBox.Show("Student Score Instered", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student Score Is Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The Score For This Course Are Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int studentID = Convert.ToInt32(dataGridView_infomation.CurrentRow.Cells[0].Value);
            string courseID = dataGridView_infomation.CurrentRow.Cells[1].Value.ToString();
            int semester = Convert.ToInt32(dataGridView_infomation.CurrentRow.Cells[5].Value);

            if ((MessageBox.Show("Are You Sure You Want To Delete This Score", "Delete Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                if (score.deleteScore(studentID, courseID, semester))
                {
                    MessageBox.Show("Score Deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Score Is Not Deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
