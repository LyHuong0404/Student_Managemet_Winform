using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Quan_Ly_Sinh_Vien
{
    public partial class PieChartForm : Form
    {
        public PieChartForm()
        {
            InitializeComponent();
        }

        private void PieChartForm_Load(object sender, EventArgs e)
        {
            STUDENTS student = new STUDENTS();
            double total = Convert.ToDouble(student.totalStudent());
            double totalMale = Convert.ToDouble(student.totalMaleStudent());
            double totalFemale = Convert.ToDouble(student.totalFemaleStudent());

            double MalePercentage = (totalMale * (100 / total));
            double FemalePercentage = (totalFemale * (100 / total));

            Piechart.Series["Seri"].Points.AddXY("Male", MalePercentage);
            Piechart.Series["Seri"].Points.AddXY("Female", FemalePercentage);
        }
    }
}
