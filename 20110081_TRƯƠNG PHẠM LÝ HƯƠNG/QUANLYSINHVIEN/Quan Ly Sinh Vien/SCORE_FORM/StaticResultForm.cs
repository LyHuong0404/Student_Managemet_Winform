using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Sinh_Vien
{
    public partial class StaticResultForm : Form
    {
        public StaticResultForm()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();

        STUDENT_SCORE stdScore = new STUDENT_SCORE();
        private void StaticResultForm_Load(object sender, EventArgs e)
        {
            //Static by Course 
            DataTable table = stdScore.AvgScore();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                float avgScore = float.Parse(table.Rows[i][1].ToString(), CultureInfo.CurrentCulture.NumberFormat);
                Label label = new Label();
                label.Text = table.Rows[i][0].ToString() + ": " + (avgScore * 10).ToString("0.00") + "%";
                label.Location = new Point(12, 42 * (i + 2));
                label.AutoSize = true;
                label.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                this.Controls.Add(label);
            }

            //Xep loai
            string sqlquery = "select round(avg(Score.student_score),2)" +
                            " From Course join Score on Course.Id = Score.course_id and Course.semester = Score.semester" +
                            " group by Score.student_id ";

            SqlCommand cmd = new SqlCommand(sqlquery, mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table1 = new DataTable();
            adapter.Fill(table1);


            //avg score
            int countRow = table1.Rows.Count;
            int countGioi = 0, countKha = 0, countTB = 0, countYeu = 0;
            for (int i = 0; i < countRow; i++)
            {
                if (Convert.ToInt32(table1.Rows[i][0]) >= 8)
                {
                    countGioi++;
                }
                else if ((Convert.ToInt32(table1.Rows[i][0]) >= 6.5) && (Convert.ToInt32(table1.Rows[i][0]) < 8))
                {
                    countKha++;
                }
                else if ((Convert.ToInt32(table1.Rows[i][0]) >= 4) && (Convert.ToInt32(table1.Rows[i][0]) < 6.5))
                {
                    countTB++;
                }
                else
                {
                    countYeu++;
                }
            }

            float Per_Gioi = ((float)countGioi / countRow) * 100;
            float Per_Kha = ((float)countKha / countRow) * 100;
            float Per_TB = ((float)countTB / countRow) * 100;
            float Per_Yeu = (float)(100 - Per_Gioi - Per_Kha - Per_TB);

            labelGioi.Text = "Giỏi: " + Per_Gioi.ToString("0.00") + "%";
            labelKha.Text = "Khá: " + Per_Kha.ToString("0.00") + "%";
            labelTB.Text = "TBinh: " + Per_TB.ToString("0.00") + "%";
            labelYeu.Text = "Yếu : " + Per_Yeu.ToString("0.00") + "%";

            //Static By Result
            double totalStd = Convert.ToInt32(stdScore.totalStudent());
            double countPass = Convert.ToInt32(stdScore.getCountPass());
            double PassPercent = (countPass) * (100 / totalStd);
            labelPassPercent.Text = "Pass: " + PassPercent.ToString("0.00") + "%";
            labelFailPercent.Text = "Fail: " + (100 - PassPercent).ToString("0.00") + "%";
        }
    }
}
