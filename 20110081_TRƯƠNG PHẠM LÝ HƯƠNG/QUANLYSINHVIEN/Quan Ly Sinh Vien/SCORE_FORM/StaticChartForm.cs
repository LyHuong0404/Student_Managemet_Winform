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
using LiveCharts;
using LiveCharts.Wpf;

namespace Quan_Ly_Sinh_Vien
{
    public partial class StaticChartForm : Form
    {
        My_DB mydb = new My_DB();
       
        public StaticChartForm()
        {
            InitializeComponent();
        }

        float Per_Gioi = 0, Per_Kha = 0, Per_TB = 0, Per_Yeu = 0;
        float[] a = new float[4];
        public void AvgScore()
        {
            string sqlquery = "select round(avg(Score.student_score),2)" +
                            " From Course join Score on Course.Id = Score.course_id and Course.semester = Score.semester" +
                            " group by Score.student_id ";

            SqlCommand cmd = new SqlCommand(sqlquery, mydb.getConnection);
        
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            //avg score
            int countRow = table.Rows.Count;

            int countGioi = 0, countKha = 0, countTB = 0, countYeu = 0;

            for (int i=0; i < countRow; i++)
            {
                if (Convert.ToInt32(table.Rows[i][0]) >= 8)
                {
                    countGioi++;
                }
                else if((Convert.ToInt32(table.Rows[i][0]) >= 6.5) && (Convert.ToInt32(table.Rows[i][0]) < 8))
                {
                    countKha++;
                }
                else if ((Convert.ToInt32(table.Rows[i][0]) >= 4) && (Convert.ToInt32(table.Rows[i][0]) < 6.5))
                {
                    countTB++;
                }
                else
                {
                    countYeu++;
                }
            }

            Per_Gioi = ((float)countGioi / countRow)*100;
            Per_Kha = ((float)countKha / countRow)*100;
            Per_TB = ((float)countTB / countRow)*100;
            Per_Yeu = (float)(100 - Per_Gioi - Per_Kha - Per_TB);
            
            

            DataTable table1 = new DataTable();
            table1.Columns.Add("Result");
            table1.Columns.Add("Percent");

            DataRow row;

            row = table1.NewRow();
            row["Result"] = "Giỏi";
            row["Percent"] = (Per_Gioi.ToString("0.00") + "%");
            table1.Rows.Add(row);

            row = table1.NewRow();
            row["Result"] = "Khá";
            row["Percent"] = (Per_Kha.ToString("0.00") + "%");
            table1.Rows.Add(row);

            row = table1.NewRow();
            row["Result"] = "Trung Bình";
            row["Percent"] = (Per_TB.ToString("0.00") + "%");
            table1.Rows.Add(row);

            row = table1.NewRow();
            row["Result"] = "Yếu";
            row["Percent"] = (Per_Yeu.ToString("0.00") + "%");
            table1.Rows.Add(row);


            dataGridViewinfor.DataSource = table1;

            a[0] = Per_Gioi;
            a[1] = Per_Kha;
            a[2] = Per_TB;
            a[3] = Per_Yeu;
        }

        private void StaticChartForm_Load(object sender, EventArgs e)
        {
            // AvgScore();

            string sqlquery = "select round(avg(Score.student_score),2)" +
                " From Course join Score on Course.Id = Score.course_id and Course.semester = Score.semester" +
                " group by Score.student_id ";

            SqlCommand cmd = new SqlCommand(sqlquery, mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            //avg score
            int countRow = table.Rows.Count;

            int countGioi = 0, countKha = 0, countTB = 0, countYeu = 0;

            for (int i = 0; i < countRow; i++)
            {
                if (Convert.ToInt32(table.Rows[i][0]) >= 8)
                {
                    countGioi++;
                }
                else if ((Convert.ToInt32(table.Rows[i][0]) >= 6.5) && (Convert.ToInt32(table.Rows[i][0]) < 8))
                {
                    countKha++;
                }
                else if ((Convert.ToInt32(table.Rows[i][0]) >= 4) && (Convert.ToInt32(table.Rows[i][0]) < 6.5))
                {
                    countTB++;
                }
                else
                {
                    countYeu++;
                }
            }

            Per_Gioi = ((float)countGioi / countRow) * 100;
            Per_Kha = ((float)countKha / countRow) * 100;
            Per_TB = ((float)countTB / countRow) * 100;
            Per_Yeu = (float)(100 - Per_Gioi - Per_Kha - Per_TB);



            DataTable table1 = new DataTable();
            table1.Columns.Add("Result");
            table1.Columns.Add("Percent");

            DataRow row;

            row = table1.NewRow();
            row["Result"] = "Giỏi";
            row["Percent"] = (Per_Gioi.ToString("0.00") + "%");
            table1.Rows.Add(row);

            row = table1.NewRow();
            row["Result"] = "Khá";
            row["Percent"] = (Per_Kha.ToString("0.00") + "%");
            table1.Rows.Add(row);

            row = table1.NewRow();
            row["Result"] = "Trung Bình";
            row["Percent"] = (Per_TB.ToString("0.00") + "%");
            table1.Rows.Add(row);

            row = table1.NewRow();
            row["Result"] = "Yếu";
            row["Percent"] = (Per_Yeu.ToString("0.00") + "%");
            table1.Rows.Add(row);


            dataGridViewinfor.DataSource = table1;

            a[0] = Per_Gioi;
            a[1] = Per_Kha;
            a[2] = Per_TB;
            a[3] = Per_Yeu;

            for (int i = 0; i < table1.Rows.Count; i++)
            {
                PieChart.Series["Seri"].Points.AddXY(dataGridViewinfor.Rows[i].Cells[0].Value.ToString(), a[i]);
            }
        }
    }
}
