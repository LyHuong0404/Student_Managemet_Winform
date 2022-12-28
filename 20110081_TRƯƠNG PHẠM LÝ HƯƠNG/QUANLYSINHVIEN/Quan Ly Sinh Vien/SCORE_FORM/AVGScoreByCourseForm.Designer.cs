
namespace Quan_Ly_Sinh_Vien
{
    partial class AVGScoreByCourseForm
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
            this.dataGridView_AVGScore = new System.Windows.Forms.DataGridView();
            this.chartAVG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelMYNAME = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AVGScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAVG)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_AVGScore
            // 
            this.dataGridView_AVGScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_AVGScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AVGScore.Location = new System.Drawing.Point(984, 12);
            this.dataGridView_AVGScore.Name = "dataGridView_AVGScore";
            this.dataGridView_AVGScore.RowHeadersWidth = 51;
            this.dataGridView_AVGScore.RowTemplate.Height = 24;
            this.dataGridView_AVGScore.Size = new System.Drawing.Size(318, 550);
            this.dataGridView_AVGScore.TabIndex = 0;
            // 
            // chartAVG
            // 
            chartArea1.Name = "ChartArea1";
            this.chartAVG.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAVG.Legends.Add(legend1);
            this.chartAVG.Location = new System.Drawing.Point(12, 12);
            this.chartAVG.Name = "chartAVG";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "AvgScoreByCourse";
            this.chartAVG.Series.Add(series1);
            this.chartAVG.Size = new System.Drawing.Size(947, 550);
            this.chartAVG.TabIndex = 1;
            this.chartAVG.Text = "AVGChart";
            // 
            // labelMYNAME
            // 
            this.labelMYNAME.AutoSize = true;
            this.labelMYNAME.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMYNAME.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMYNAME.Location = new System.Drawing.Point(906, 575);
            this.labelMYNAME.Name = "labelMYNAME";
            this.labelMYNAME.Size = new System.Drawing.Size(360, 27);
            this.labelMYNAME.TabIndex = 40;
            this.labelMYNAME.Text = "20110081_Trương Phạm Lý Hương";
            // 
            // AVGScoreByCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 611);
            this.Controls.Add(this.labelMYNAME);
            this.Controls.Add(this.chartAVG);
            this.Controls.Add(this.dataGridView_AVGScore);
            this.Name = "AVGScoreByCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVGScoreByCourseForm";
            this.Load += new System.EventHandler(this.AVGScoreByCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AVGScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAVG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_AVGScore;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAVG;
        private System.Windows.Forms.Label labelMYNAME;
    }
}