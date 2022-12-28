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
    public partial class MainForm01 : Form
    {
        public MainForm01()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStdF = new AddStudentForm();
            addStdF.Show(this);
        }
        
        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentListForm StdList = new StudentListForm();
            StdList.Show(this);
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticsForm staF = new StaticsForm();
            staF.Show(this);
        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentForm manaStd = new ManageStudentForm();
            manaStd.Show(this);
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm UpdateDeleteStd = new UpdateDeleteStudentForm();
            UpdateDeleteStd.Show(this);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintSaveForm printSaveF = new PrintSaveForm();
            printSaveF.Show(this);
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm addF = new AddCourseForm();
            addF.Show(this);
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourseForm removeF = new RemoveCourseForm();
            removeF.Show(this);
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCousreForm editF = new EditCousreForm();
            editF.Show(this);
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourseForm manaCF = new ManageCourseForm();
            manaCF.Show();
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintCourseForm printCF = new PrintCourseForm(); 
            printCF.Show();
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm addscoreF = new AddScoreForm();
            addscoreF.Show();
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScoreForm removeScoreF = new RemoveScoreForm();
            removeScoreF.Show();
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScoreForm manageScoreF = new ManageScoreForm();
            manageScoreF.Show();
        }

        private void avgScooreByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AVGScoreByCourseForm aVGScoreByCourseForm = new AVGScoreByCourseForm();
            aVGScoreByCourseForm.Show();
        }

        private void aVGResultByScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AVGResultForm resultForm = new AVGResultForm();
            resultForm.Show();
        }

        private void staticsResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticResultForm staticResultForm = new StaticResultForm();
            staticResultForm.Show();
        }

        private void resultChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticChartForm staticChartForm = new StaticChartForm();
            staticChartForm.Show();
        }

        private void printScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintScoreForm printScoreForm = new PrintScoreForm();
            printScoreForm.Show();
        }
    }
}
