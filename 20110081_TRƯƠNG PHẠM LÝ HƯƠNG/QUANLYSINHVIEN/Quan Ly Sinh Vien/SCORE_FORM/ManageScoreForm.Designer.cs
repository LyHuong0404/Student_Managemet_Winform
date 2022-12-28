
namespace Quan_Ly_Sinh_Vien
{
    partial class ManageScoreForm
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
            this.dataGridView_infomation = new System.Windows.Forms.DataGridView();
            this.comboSelectCourse = new System.Windows.Forms.ComboBox();
            this.labelSelectCourse = new System.Windows.Forms.Label();
            this.labelMYNAME = new System.Windows.Forms.Label();
            this.buttonAverage = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelCourseID = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonShowStudent = new System.Windows.Forms.Button();
            this.buttonShowScore = new System.Windows.Forms.Button();
            this.labelSemester = new System.Windows.Forms.Label();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_infomation)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_infomation
            // 
            this.dataGridView_infomation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_infomation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_infomation.Location = new System.Drawing.Point(502, 73);
            this.dataGridView_infomation.Name = "dataGridView_infomation";
            this.dataGridView_infomation.RowHeadersWidth = 51;
            this.dataGridView_infomation.RowTemplate.Height = 24;
            this.dataGridView_infomation.Size = new System.Drawing.Size(900, 468);
            this.dataGridView_infomation.TabIndex = 78;
            this.dataGridView_infomation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_infomation_CellDoubleClick);
            // 
            // comboSelectCourse
            // 
            this.comboSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSelectCourse.FormattingEnabled = true;
            this.comboSelectCourse.Location = new System.Drawing.Point(192, 161);
            this.comboSelectCourse.Name = "comboSelectCourse";
            this.comboSelectCourse.Size = new System.Drawing.Size(255, 28);
            this.comboSelectCourse.TabIndex = 77;
            // 
            // labelSelectCourse
            // 
            this.labelSelectCourse.AutoSize = true;
            this.labelSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSelectCourse.Location = new System.Drawing.Point(12, 157);
            this.labelSelectCourse.Name = "labelSelectCourse";
            this.labelSelectCourse.Size = new System.Drawing.Size(171, 29);
            this.labelSelectCourse.TabIndex = 76;
            this.labelSelectCourse.Text = "Select Course:";
            // 
            // labelMYNAME
            // 
            this.labelMYNAME.AutoSize = true;
            this.labelMYNAME.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMYNAME.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMYNAME.Location = new System.Drawing.Point(1024, 544);
            this.labelMYNAME.Name = "labelMYNAME";
            this.labelMYNAME.Size = new System.Drawing.Size(360, 27);
            this.labelMYNAME.TabIndex = 75;
            this.labelMYNAME.Text = "20110081_Trương Phạm Lý Hương";
            // 
            // buttonAverage
            // 
            this.buttonAverage.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAverage.Location = new System.Drawing.Point(20, 499);
            this.buttonAverage.Name = "buttonAverage";
            this.buttonAverage.Size = new System.Drawing.Size(379, 42);
            this.buttonAverage.TabIndex = 74;
            this.buttonAverage.Text = "Average Score By Course";
            this.buttonAverage.UseVisualStyleBackColor = false;
            this.buttonAverage.Click += new System.EventHandler(this.buttonAverage_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(192, 297);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(255, 113);
            this.textBoxDescription.TabIndex = 73;
            // 
            // textBoxScore
            // 
            this.textBoxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScore.Location = new System.Drawing.Point(192, 229);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(124, 30);
            this.textBoxScore.TabIndex = 72;
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentID.Location = new System.Drawing.Point(192, 32);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(137, 30);
            this.textBoxStudentID.TabIndex = 71;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDescription.Location = new System.Drawing.Point(45, 297);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(141, 29);
            this.labelDescription.TabIndex = 70;
            this.labelDescription.Text = "Description:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelScore.Location = new System.Drawing.Point(103, 229);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(83, 29);
            this.labelScore.TabIndex = 69;
            this.labelScore.Text = "Score:";
            // 
            // labelCourseID
            // 
            this.labelCourseID.AutoSize = true;
            this.labelCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCourseID.Location = new System.Drawing.Point(56, 32);
            this.labelCourseID.Name = "labelCourseID";
            this.labelCourseID.Size = new System.Drawing.Size(130, 29);
            this.labelCourseID.TabIndex = 68;
            this.labelCourseID.Text = "Student ID:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Peru;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(20, 434);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(175, 42);
            this.buttonAdd.TabIndex = 79;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Brown;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(224, 434);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(175, 42);
            this.buttonRemove.TabIndex = 80;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonShowStudent
            // 
            this.buttonShowStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowStudent.Location = new System.Drawing.Point(502, 25);
            this.buttonShowStudent.Name = "buttonShowStudent";
            this.buttonShowStudent.Size = new System.Drawing.Size(416, 42);
            this.buttonShowStudent.TabIndex = 81;
            this.buttonShowStudent.Text = "Show Students";
            this.buttonShowStudent.UseVisualStyleBackColor = true;
            this.buttonShowStudent.Click += new System.EventHandler(this.buttonShowStudent_Click);
            // 
            // buttonShowScore
            // 
            this.buttonShowScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowScore.Location = new System.Drawing.Point(1012, 25);
            this.buttonShowScore.Name = "buttonShowScore";
            this.buttonShowScore.Size = new System.Drawing.Size(390, 42);
            this.buttonShowScore.TabIndex = 82;
            this.buttonShowScore.Text = "Show Scores";
            this.buttonShowScore.UseVisualStyleBackColor = true;
            this.buttonShowScore.Click += new System.EventHandler(this.buttonShowScore_Click);
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemester.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSemester.Location = new System.Drawing.Point(63, 88);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(123, 29);
            this.labelSemester.TabIndex = 83;
            this.labelSemester.Text = "Semester:";
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxSemester.Location = new System.Drawing.Point(192, 88);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(68, 33);
            this.comboBoxSemester.TabIndex = 84;
            this.comboBoxSemester.SelectedValueChanged += new System.EventHandler(this.comboBoxSemester_SelectedValueChanged);
            // 
            // ManageScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1425, 580);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.buttonShowScore);
            this.Controls.Add(this.buttonShowStudent);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView_infomation);
            this.Controls.Add(this.comboSelectCourse);
            this.Controls.Add(this.labelSelectCourse);
            this.Controls.Add(this.labelMYNAME);
            this.Controls.Add(this.buttonAverage);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelCourseID);
            this.Name = "ManageScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageScoreForm";
            this.Load += new System.EventHandler(this.ManageScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_infomation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_infomation;
        private System.Windows.Forms.ComboBox comboSelectCourse;
        private System.Windows.Forms.Label labelSelectCourse;
        private System.Windows.Forms.Label labelMYNAME;
        private System.Windows.Forms.Button buttonAverage;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelCourseID;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonShowStudent;
        private System.Windows.Forms.Button buttonShowScore;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.ComboBox comboBoxSemester;
    }
}