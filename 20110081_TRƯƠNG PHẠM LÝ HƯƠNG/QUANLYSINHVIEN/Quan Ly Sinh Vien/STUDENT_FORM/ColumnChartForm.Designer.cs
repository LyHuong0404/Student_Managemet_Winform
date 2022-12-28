
namespace Quan_Ly_Sinh_Vien
{
    partial class ColumnChartForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ColumnChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelMYNAME = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ColumnChart
            // 
            this.ColumnChart.BorderlineWidth = 5;
            chartArea1.Name = "ChartArea1";
            this.ColumnChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ColumnChart.Legends.Add(legend1);
            this.ColumnChart.Location = new System.Drawing.Point(29, 31);
            this.ColumnChart.Name = "ColumnChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Male";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Female";
            this.ColumnChart.Series.Add(series1);
            this.ColumnChart.Series.Add(series2);
            this.ColumnChart.Size = new System.Drawing.Size(660, 367);
            this.ColumnChart.TabIndex = 0;
            this.ColumnChart.Text = "Column Chart";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.Red;
            title1.Name = "Title1";
            title1.Text = "COLUMN CHART";
            this.ColumnChart.Titles.Add(title1);
            // 
            // labelMYNAME
            // 
            this.labelMYNAME.AutoSize = true;
            this.labelMYNAME.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMYNAME.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMYNAME.Location = new System.Drawing.Point(287, 414);
            this.labelMYNAME.Name = "labelMYNAME";
            this.labelMYNAME.Size = new System.Drawing.Size(360, 27);
            this.labelMYNAME.TabIndex = 40;
            this.labelMYNAME.Text = "20110081_Trương Phạm Lý Hương";
            // 
            // ColumnChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.labelMYNAME);
            this.Controls.Add(this.ColumnChart);
            this.Name = "ColumnChartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColumnChatForm";
            this.Load += new System.EventHandler(this.ColumnChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ColumnChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ColumnChart;
        private System.Windows.Forms.Label labelMYNAME;
    }
}