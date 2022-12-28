using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Sinh_Vien
{
    public partial class AddScoreForm : Form
    {
        public AddScoreForm()
        {
            InitializeComponent();
        }
        COURSES course = new COURSES();
        STUDENT_SCORE score = new STUDENT_SCORE();
        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            dataGridView_infoStudent.DataSource = score.getStudentsScore();
  
        }

        
        private void dataGridView_infoStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxStudentID.Text = dataGridView_infoStudent.CurrentRow.Cells[0].Value.ToString();
            comboBoxSemester.Text = "";
            comboSelectCourse.Text = "";
            textBoxScore.Text = "";
            textBoxDescription.Text = "";
        }

        private void buttonAddScore_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(textBoxStudentID.Text);
                string courseID = (string)comboSelectCourse.SelectedValue;
                double scorevalue = Convert.ToInt32(textBoxScore.Text);
                string description = textBoxDescription.Text;
                int semester = Convert.ToInt32(comboBoxSemester.Text);
       

                if (!score.studentScoreExist(studentID, courseID))
                {
                    if (score.insertScore(studentID, courseID, scorevalue, description, semester))
                    {
                        MessageBox.Show("Student Score Instered", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AddScoreForm_Load(null, null);
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

        private void comboBoxSemester_SelectedValueChanged(object sender, EventArgs e)
        {
            int studentID = Convert.ToInt32(textBoxStudentID.Text);
            int semester = Convert.ToInt32(comboBoxSemester.Text);

            comboSelectCourse.DataSource = course.getStudentCoursesByStdID(studentID, semester);
            comboSelectCourse.ValueMember = "CourseID";
            comboSelectCourse.DisplayMember = "CourseName";
        }
    }
}
