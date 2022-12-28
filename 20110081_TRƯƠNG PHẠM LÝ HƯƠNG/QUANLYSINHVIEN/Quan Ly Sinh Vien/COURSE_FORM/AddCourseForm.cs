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
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                string cID = textBoxCourseID.Text;
                string name = textBoxLabel.Text;
                int hours = Convert.ToInt32(textBoxPeriod.Text);
                string descrip = textBoxDescription.Text;
                int semester = Convert.ToInt32(comboBoxSemester.Text);

                COURSES course = new COURSES();

                if (name.Trim() == "")
                {
                    MessageBox.Show("Add a Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (course.checkCourseName(name, cID))
                {
                    if (course.insertCourse(cID, name, hours, descrip, semester))
                    {
                        MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxCourseID.Text = "";
                        textBoxLabel.Text = "";
                        textBoxPeriod.Text = "";
                        textBoxDescription.Text = "";
                        comboBoxSemester.Text = "";
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
                MessageBox.Show("This Course Name Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            //so
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
