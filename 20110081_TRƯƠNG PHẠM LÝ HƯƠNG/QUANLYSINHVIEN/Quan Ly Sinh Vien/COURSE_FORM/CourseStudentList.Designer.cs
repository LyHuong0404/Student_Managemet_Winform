
namespace Quan_Ly_Sinh_Vien
{
    partial class CourseStudentList
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
            this.labelCourseID = new System.Windows.Forms.Label();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.labelSemester = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.dataGridView_information = new System.Windows.Forms.DataGridView();
            this.buttonShow = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.labelMYNAME = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_information)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCourseID
            // 
            this.labelCourseID.AutoSize = true;
            this.labelCourseID.BackColor = System.Drawing.Color.Transparent;
            this.labelCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCourseID.Location = new System.Drawing.Point(16, 18);
            this.labelCourseID.Name = "labelCourseID";
            this.labelCourseID.Size = new System.Drawing.Size(162, 29);
            this.labelCourseID.TabIndex = 1;
            this.labelCourseID.Text = "Course Name";
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCourseName.Location = new System.Drawing.Point(184, 18);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(177, 30);
            this.textBoxCourseName.TabIndex = 2;
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemester.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSemester.Location = new System.Drawing.Point(367, 19);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(117, 29);
            this.labelSemester.TabIndex = 3;
            this.labelSemester.Text = "Semester";
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(273, 403);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(137, 35);
            this.buttonPrint.TabIndex = 7;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxSemester.Location = new System.Drawing.Point(490, 14);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(72, 33);
            this.comboBoxSemester.TabIndex = 8;
            // 
            // dataGridView_information
            // 
            this.dataGridView_information.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_information.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_information.Location = new System.Drawing.Point(21, 68);
            this.dataGridView_information.Name = "dataGridView_information";
            this.dataGridView_information.RowHeadersWidth = 51;
            this.dataGridView_information.RowTemplate.Height = 24;
            this.dataGridView_information.Size = new System.Drawing.Size(541, 329);
            this.dataGridView_information.TabIndex = 9;
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.Location = new System.Drawing.Point(73, 403);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(137, 35);
            this.buttonShow.TabIndex = 10;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // labelMYNAME
            // 
            this.labelMYNAME.AutoSize = true;
            this.labelMYNAME.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMYNAME.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMYNAME.Location = new System.Drawing.Point(179, 445);
            this.labelMYNAME.Name = "labelMYNAME";
            this.labelMYNAME.Size = new System.Drawing.Size(360, 27);
            this.labelMYNAME.TabIndex = 41;
            this.labelMYNAME.Text = "20110081_Trương Phạm Lý Hương";
            // 
            // CourseStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(597, 481);
            this.Controls.Add(this.labelMYNAME);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.dataGridView_information);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.labelCourseID);
            this.Name = "CourseStudentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseStudentList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_information)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCourseID;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.DataGridView dataGridView_information;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label labelMYNAME;
    }
}