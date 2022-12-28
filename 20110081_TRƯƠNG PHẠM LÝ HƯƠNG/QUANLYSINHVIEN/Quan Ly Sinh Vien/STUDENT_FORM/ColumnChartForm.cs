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
    public partial class ColumnChartForm : Form
    {
        public ColumnChartForm()
        {
            InitializeComponent();
        }

        private void ColumnChartForm_Load(object sender, EventArgs e)
        {
            STUDENTS student = new STUDENTS();
            double total = Convert.ToDouble(student.totalStudent());
            double totalMale = Convert.ToDouble(student.totalMaleStudent());
            double totalFemale = Convert.ToDouble(student.totalFemaleStudent());

            double MalePercentage = (totalMale * (100 / total));
            double FemalePercentage = (totalFemale * (100 / total));

            ColumnChart.Series["Male"].Points.AddY(MalePercentage);
            //ColumnChart.Series["Male"].Points[0].Label = MalePercentage.ToString("0.00") +"%";

            ColumnChart.Series["Female"].Points.AddY(FemalePercentage);
            //ColumnChart.Series["Female"].Points[1].Label = FemalePercentage.ToString("0.00") + "%";
        }
    }
}
