
namespace Quan_Ly_Sinh_Vien
{
    partial class StudenList_HR
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
            this.labelCreate = new System.Windows.Forms.Label();
            this.labelStudentList = new System.Windows.Forms.Label();
            this.labelCourseName = new System.Windows.Forms.Label();
            this.dataGridViewListStudent = new System.Windows.Forms.DataGridView();
            this.labelContactID = new System.Windows.Forms.Label();
            this.labelSemester = new System.Windows.Forms.Label();
            this.labelContactName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCreate
            // 
            this.labelCreate.AutoSize = true;
            this.labelCreate.BackColor = System.Drawing.Color.Transparent;
            this.labelCreate.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCreate.Location = new System.Drawing.Point(385, 84);
            this.labelCreate.Name = "labelCreate";
            this.labelCreate.Size = new System.Drawing.Size(169, 32);
            this.labelCreate.TabIndex = 96;
            this.labelCreate.Text = "Course Name:";
            // 
            // labelStudentList
            // 
            this.labelStudentList.AutoSize = true;
            this.labelStudentList.BackColor = System.Drawing.Color.Transparent;
            this.labelStudentList.Font = new System.Drawing.Font("Rockwell", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelStudentList.Location = new System.Drawing.Point(290, 24);
            this.labelStudentList.Name = "labelStudentList";
            this.labelStudentList.Size = new System.Drawing.Size(208, 42);
            this.labelStudentList.TabIndex = 97;
            this.labelStudentList.Text = "Student List";
            // 
            // labelCourseName
            // 
            this.labelCourseName.AutoSize = true;
            this.labelCourseName.BackColor = System.Drawing.Color.Transparent;
            this.labelCourseName.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCourseName.Location = new System.Drawing.Point(579, 84);
            this.labelCourseName.Name = "labelCourseName";
            this.labelCourseName.Size = new System.Drawing.Size(209, 32);
            this.labelCourseName.TabIndex = 98;
            this.labelCourseName.Text = "labelCourseName";
            // 
            // dataGridViewListStudent
            // 
            this.dataGridViewListStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListStudent.Location = new System.Drawing.Point(40, 129);
            this.dataGridViewListStudent.Name = "dataGridViewListStudent";
            this.dataGridViewListStudent.RowHeadersWidth = 51;
            this.dataGridViewListStudent.RowTemplate.Height = 24;
            this.dataGridViewListStudent.Size = new System.Drawing.Size(721, 320);
            this.dataGridViewListStudent.TabIndex = 99;
            // 
            // labelContactID
            // 
            this.labelContactID.AutoSize = true;
            this.labelContactID.Location = new System.Drawing.Point(689, 0);
            this.labelContactID.Name = "labelContactID";
            this.labelContactID.Size = new System.Drawing.Size(46, 17);
            this.labelContactID.TabIndex = 100;
            this.labelContactID.Text = "label2";
            this.labelContactID.Visible = false;
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Location = new System.Drawing.Point(589, 19);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(46, 17);
            this.labelSemester.TabIndex = 101;
            this.labelSemester.Text = "label2";
            this.labelSemester.Visible = false;
            // 
            // labelContactName
            // 
            this.labelContactName.AutoSize = true;
            this.labelContactName.BackColor = System.Drawing.Color.Transparent;
            this.labelContactName.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelContactName.Location = new System.Drawing.Point(43, 84);
            this.labelContactName.Name = "labelContactName";
            this.labelContactName.Size = new System.Drawing.Size(99, 32);
            this.labelContactName.TabIndex = 102;
            this.labelContactName.Text = "Contact";
            // 
            // StudenList_HR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.labelContactName);
            this.Controls.Add(this.dataGridViewListStudent);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.labelContactID);
            this.Controls.Add(this.labelCourseName);
            this.Controls.Add(this.labelStudentList);
            this.Controls.Add(this.labelCreate);
            this.Name = "StudenList_HR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudenList_HR";
            this.Load += new System.EventHandler(this.StudenList_HR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCreate;
        private System.Windows.Forms.Label labelStudentList;
        public System.Windows.Forms.Label labelCourseName;
        private System.Windows.Forms.DataGridView dataGridViewListStudent;
        public System.Windows.Forms.Label labelContactID;
        public System.Windows.Forms.Label labelSemester;
        public System.Windows.Forms.Label labelContactName;
    }
}