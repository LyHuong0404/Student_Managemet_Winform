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
    public partial class RemoveCourseForm : Form
    {
        public RemoveCourseForm()
        {
            InitializeComponent();
        }

        private void buttonRemoveCourse_Click(object sender, EventArgs e)
        {
            string id = textBoxCourseID.Text;
            int hocky = Convert.ToInt32(comboBoxSemester.Text);

            COURSES course = new COURSES();

            try
            {
                if (MessageBox.Show("Are you sure want to remove this course?", "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (course.removeCourse(id, hocky))
                    {
                        MessageBox.Show("Removed Course Successfully!!!", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Course Is Not Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch{
                MessageBox.Show("Error Course ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
