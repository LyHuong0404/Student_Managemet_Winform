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
using System.Windows.Forms.DataVisualization.Charting;

namespace Quan_Ly_Sinh_Vien
{
    public partial class AVGScoreByCourseForm : Form
    {
        public AVGScoreByCourseForm()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();
        STUDENT_SCORE stdScore = new STUDENT_SCORE();
        private void AVGScoreByCourseForm_Load(object sender, EventArgs e)
        {
            dataGridView_AVGScore.DataSource = stdScore.AvgScore();

            chartAVG.DataSource = stdScore.AvgScore();
            chartAVG.Series["AvgScoreByCourse"].XValueMember = "CourseName";
            chartAVG.Series["AvgScoreByCourse"].YValueMembers = "AverageGrade";
            //chartAVG.Titles.Add("Avg Score By Course Chart");
            //chartAVG.DataBindTable(stdScore.AvgScore().DefaultView, "CourseName");

          /*  chartAVG.DataSource = stdScore.AvgScore();
           // chartAVG.Series[0].ChartType = (SeriesChartType)int.Parse(rblChartType.SelectedItem.Value);
            chartAVG.Legends[0].Enabled = true;
            chartAVG.Series[0].XValueMember = "CourseName";
            chartAVG.Series[0].YValueMembers = "AverageGrade";
            chartAVG.DataBind();*/
        }
    }
}
