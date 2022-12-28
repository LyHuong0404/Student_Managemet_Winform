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
    public partial class StaticsForm : Form
    {
        public StaticsForm()
        {
            InitializeComponent();
        }
        Color panlTotalColor;
        Color panlTotalSTDFemle;
        Color panlTotalSTDMale;
        private void StaticsForm_Load(object sender, EventArgs e)
        {
            panlTotalColor = Color.White;
            panlTotalSTDFemle = Color.White;
            panlTotalSTDMale = Color.White;

            //display the values 
            STUDENTS student = new STUDENTS();
            double total = Convert.ToDouble(student.totalStudent());
            double totalMale = Convert.ToDouble(student.totalMaleStudent());
            double totalFemale = Convert.ToDouble(student.totalFemaleStudent());

            //tính %
            //(Tong student x 100)/ (total student)
            double MalePercentage = (totalMale * (100 / total));
            double FemalePercentage = (totalFemale * (100 / total));
            labelTotal.Text = "Total Student: " + total.ToString();
            labelMale.Text = "Male: " + MalePercentage.ToString("0.00") + "%";
            labelFemale.Text = "Female: " + FemalePercentage.ToString("0.00") + "%";
        }

        //các event với Mouse

        private void labelTotal_MouseLeave(object sender, EventArgs e)
        {
            labelTotal.ForeColor = Color.Black;
            panelTotal.BackColor = labelTotal.BackColor;
        }
        private void labelMale_MouseLeave(object sender, EventArgs e)
        {
            labelMale.ForeColor = Color.Black;
            panelMale.BackColor = labelMale.BackColor;
        }
        private void labelFemale_MouseLeave(object sender, EventArgs e)
        {
            labelFemale.ForeColor = Color.Black;
            panelFemale.BackColor = labelFemale.BackColor;
        }
        private void labelTotal_MouseHover(object sender, EventArgs e)
        {
            labelTotal.ForeColor = panlTotalColor;
            panelTotal.BackColor = Color.White;
        }
        private void labelMale_MouseHover(object sender, EventArgs e)
        {
            labelMale.ForeColor = panlTotalSTDFemle;
            panelMale.BackColor = Color.White;
        }

        private void labelFemale_MouseHover(object sender, EventArgs e)
        {
            labelFemale.ForeColor = panlTotalSTDMale;
            panelFemale.BackColor = Color.White;
        }

        private void buttonColumnChart_Click(object sender, EventArgs e)
        {
            ColumnChartForm columnChart = new ColumnChartForm();
            columnChart.ShowDialog();
        }

        private void buttonPieChart_Click(object sender, EventArgs e)
        {
            PieChartForm pieChart = new PieChartForm();
            pieChart.ShowDialog();
        }
    }
}
