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
    public partial class RemoveScoreForm : Form
    {
        public RemoveScoreForm()
        {
            InitializeComponent();
        }
        STUDENT_SCORE stdScore = new STUDENT_SCORE();
        private void RemoveScoreForm_Load(object sender, EventArgs e)
        {
            dataGridView_infomation.DataSource = stdScore.getStudentsScore();
        }

        private void buttonRemoveScore_Click(object sender, EventArgs e)
        {
            int studentID = Convert.ToInt32(dataGridView_infomation.CurrentRow.Cells[0].Value);
            string courseID = dataGridView_infomation.CurrentRow.Cells[3].Value.ToString();
            int semester = Convert.ToInt32(dataGridView_infomation.CurrentRow.Cells[5].Value);

            if ((MessageBox.Show("Are You Sure You Want To Delete This Score", "Delete Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                if(stdScore.deleteScore(studentID, courseID,semester))
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
