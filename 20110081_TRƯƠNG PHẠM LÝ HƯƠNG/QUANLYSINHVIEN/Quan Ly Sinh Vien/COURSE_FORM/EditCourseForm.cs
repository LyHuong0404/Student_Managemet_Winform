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
    public partial class EditCousreForm : Form
    {
        COURSES course = new COURSES();
        public EditCousreForm()
        {
            InitializeComponent();
        }

        private void buttonEditCourse_Click(object sender, EventArgs e)
        {
            string id = (string)comboBoxCourse.SelectedValue;
            string name = textBoxLabel.Text;
            int hours = (int)numericUpDownPeriod.Value;
            string descrip = textBoxDescription.Text;
            int semester = Convert.ToInt32(comboBoxSemester.Text);

            if (!course.checkCourseName(name, (string)comboBoxCourse.SelectedValue))
            {
                MessageBox.Show("This Course Name Already Exists", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (course.updateCourse(id, name, hours, descrip, semester))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EditCousreForm_Load(object sender, EventArgs e)
        {
            //dung combobox lay ten course
            comboBoxCourse.DataSource = course.getAllCourse();
            comboBoxCourse.DisplayMember = "lable";
            comboBoxCourse.ValueMember = "Id";
            comboBoxCourse.SelectedItem = null;
        }

        public void fillCombo(int index)
        {
            comboBoxCourse.DataSource = course.getAllCourse();
            comboBoxCourse.DisplayMember = "lable";
            comboBoxCourse.ValueMember = "Id";
            comboBoxCourse.SelectedItem = index;
        }

        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //lay du lieu
                string id = (string)comboBoxCourse.SelectedValue;
                DataTable table = new DataTable();
                table = course.getCourseById(id);
                textBoxLabel.Text = table.Rows[0][1].ToString();
                numericUpDownPeriod.Value = Int32.Parse(table.Rows[0][2].ToString());
                textBoxDescription.Text = table.Rows[0][3].ToString();
                comboBoxSemester.DisplayMember = table.Rows[0][4].ToString();  //*****************
            }
            catch 
            {
            }
        }
    }
}
