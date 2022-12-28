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
    public partial class ManageCourseForm : Form
    {
        COURSES course = new COURSES();
        int pos;
        public ManageCourseForm()
        {
            InitializeComponent();
        }

        
        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            reloadListBoxData();
        }

        void reloadListBoxData()
        {
            listBoxCourse.DataSource = course.getAllCourse();
            listBoxCourse.ValueMember = "Id";
            listBoxCourse.DisplayMember = "lable";
            labelTotal.Text = "Total Courses: " + course.totalCourse();
        }
        void showData(int index)
        {
            DataRow dr = course.getAllCourse().Rows[index];
            listBoxCourse.SelectedIndex = index;
            textBoxCourseID.Text = dr.ItemArray[0].ToString();
            textBoxLable.Text = dr.ItemArray[1].ToString();
            numericUpDown.Value = int.Parse(dr.ItemArray[2].ToString());
            textBoxDescription.Text = dr.ItemArray[3].ToString();
            comboBoxSemester.Text = dr.ItemArray[4].ToString();
        }

        private void listBoxCourse_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)listBoxCourse.SelectedItem;
            pos = listBoxCourse.SelectedIndex;
            showData(pos);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string cID = textBoxCourseID.Text;
                string name = textBoxLable.Text;
                int hours = (int)numericUpDown.Value;
                string descrip = textBoxDescription.Text;
                int semester = Convert.ToInt32(comboBoxSemester.Text);

                if (name.Trim() == "")
                {
                    MessageBox.Show("Add a Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (course.checkCourseName(name, cID))
                {
                    if (course.insertCourse(cID, name, hours, descrip, semester))
                    {
                        MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadListBoxData();
                    }
                    else
                    {
                        MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("This Course Name Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("This Course Name Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBoxCourseID.Text;
                string name = textBoxLable.Text;
                int hours = (int)numericUpDown.Value;
                string descrip = textBoxDescription.Text;
                int semester = Convert.ToInt32(comboBoxSemester.Text);

                if (!course.checkCourseName(name, id))
                {
                    MessageBox.Show("This Course Name Already Exists", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (course.updateCourse(id, name, hours, descrip, semester))
                {
                    MessageBox.Show("Course Updated Successfully!!", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("This Course Name Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string id = textBoxCourseID.Text;
            int hocky = Convert.ToInt32(comboBoxSemester.Text);
            try
            {
                if (MessageBox.Show("Are you sure want to remove this course?", "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (course.removeCourse(id, hocky))
                    {
                        MessageBox.Show("Removed Course Successfully!!!", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBoxCourseID.Text = "";
                        textBoxLable.Text = "";
                        numericUpDown.Value = 0;
                        textBoxDescription.Text = "";

                        reloadListBoxData();
                    }
                    else
                    {
                        MessageBox.Show("Course Is Not Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error Course ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pos = 0;
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (pos < course.getAllCourse().Rows.Count - 1)
            {
                pos += 1;
                showData(pos);
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos -= 1;
                showData(pos);
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            pos = course.getAllCourse().Rows.Count - 1;
            showData(pos);
        }
        private void buttonFirst_MouseHover(object sender, EventArgs e)
        {
            buttonFirst.BackColor = Color.Blue;
        }

        private void buttonFirst_MouseLeave(object sender, EventArgs e)
        {
            buttonFirst.BackColor = Color.DarkGray;
        }

        private void buttonNext_MouseHover(object sender, EventArgs e)
        {
            buttonNext.BackColor = Color.Blue;
        }

        private void buttonNext_MouseLeave(object sender, EventArgs e)
        {
            buttonNext.BackColor = Color.DarkGray;
        }

        private void buttonPrevious_MouseHover(object sender, EventArgs e)
        {
            buttonPrevious.BackColor = Color.Blue;
        }

        private void buttonPrevious_MouseLeave(object sender, EventArgs e)
        {
            buttonPrevious.BackColor = Color.DarkGray;
        }

        private void buttonLast_MouseHover(object sender, EventArgs e)
        {
            buttonLast.BackColor = Color.Blue;
        }

        private void buttonLast_MouseLeave(object sender, EventArgs e)
        {
            buttonLast.BackColor = Color.DarkGray;
        }
    }
}
