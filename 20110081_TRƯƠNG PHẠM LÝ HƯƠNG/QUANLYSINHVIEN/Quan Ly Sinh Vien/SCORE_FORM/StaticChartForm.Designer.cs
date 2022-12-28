
namespace Quan_Ly_Sinh_Vien
{
    partial class StaticChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridViewinfor = new System.Windows.Forms.DataGridView();
            this.labelMYNAME = new System.Windows.Forms.Label();
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewinfor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewinfor
            // 
            this.dataGridViewinfor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewinfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewinfor.Location = new System.Drawing.Point(553, 50);
            this.dataGridViewinfor.Name = "dataGridViewinfor";
            this.dataGridViewinfor.RowHeadersWidth = 51;
            this.dataGridViewinfor.RowTemplate.Height = 24;
            this.dataGridViewinfor.Size = new System.Drawing.Size(348, 380);
            this.dataGridViewinfor.TabIndex = 9;
            // 
            // labelMYNAME
            // 
            this.labelMYNAME.AutoSize = true;
            this.labelMYNAME.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMYNAME.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMYNAME.Location = new System.Drawing.Point(541, 470);
            this.labelMYNAME.Name = "labelMYNAME";
            this.labelMYNAME.Size = new System.Drawing.Size(360, 27);
            this.labelMYNAME.TabIndex = 65;
            this.labelMYNAME.Text = "20110081_Trương Phạm Lý Hương";
            // 
            // PieChart
            // 
            chartArea1.Name = "ChartArea1";
            this.PieChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.PieChart.Legends.Add(legend1);
            this.PieChart.Location = new System.Drawing.Point(12, 50);
            this.PieChart.Name = "PieChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Seri";
            this.PieChart.Series.Add(series1);
            this.PieChart.Size = new System.Drawing.Size(499, 378);
            this.PieChart.TabIndex = 66;
            this.PieChart.Text = "chart1";
            // 
            // StaticChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(938, 510);
            this.Controls.Add(this.PieChart);
            this.Controls.Add(this.labelMYNAME);
            this.Controls.Add(this.dataGridViewinfor);
            this.Name = "StaticChartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticChartForm";
            this.Load += new System.EventHandler(this.StaticChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewinfor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridViewinfor;
        private System.Windows.Forms.Label labelMYNAME;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
    }
}