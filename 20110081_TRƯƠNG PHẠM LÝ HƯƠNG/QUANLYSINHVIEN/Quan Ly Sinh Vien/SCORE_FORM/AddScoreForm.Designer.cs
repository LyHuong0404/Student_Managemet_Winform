
namespace Quan_Ly_Sinh_Vien
{
    partial class AddScoreForm
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
            this.components = new System.ComponentModel.Container();
            this.comboSelectCourse = new System.Windows.Forms.ComboBox();
            this.labelSelectCourse = new System.Windows.Forms.Label();
            this.labelMYNAME = new System.Windows.Forms.Label();
            this.buttonAddScore = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelCourseID = new System.Windows.Forms.Label();
            this.stdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYSINHVIENDataSet3 = new Quan_Ly_Sinh_Vien.QUANLYSINHVIENDataSet3();
            this.stdTableAdapter = new Quan_Ly_Sinh_Vien.QUANLYSINHVIENDataSet3TableAdapters.stdTableAdapter();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.labelSemester = new System.Windows.Forms.Label();
            this.dataGridView_infoStudent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYSINHVIENDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_infoStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // comboSelectCourse
            // 
            this.comboSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSelectCourse.FormattingEnabled = true;
            this.comboSelectCourse.Location = new System.Drawing.Point(197, 130);
            this.comboSelectCourse.Name = "comboSelectCourse";
            this.comboSelectCourse.Size = new System.Drawing.Size(294, 28);
            this.comboSelectCourse.TabIndex = 66;
            // 
            // labelSelectCourse
            // 
            this.labelSelectCourse.AutoSize = true;
            this.labelSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSelectCourse.Location = new System.Drawing.Point(16, 130);
            this.labelSelectCourse.Name = "labelSelectCourse";
            this.labelSelectCourse.Size = new System.Drawing.Size(171, 29);
            this.labelSelectCourse.TabIndex = 65;
            this.labelSelectCourse.Text = "Select Course:";
            // 
            // labelMYNAME
            // 
            this.labelMYNAME.AutoSize = true;
            this.labelMYNAME.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMYNAME.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMYNAME.Location = new System.Drawing.Point(502, 414);
            this.labelMYNAME.Name = "labelMYNAME";
            this.labelMYNAME.Size = new System.Drawing.Size(360, 27);
            this.labelMYNAME.TabIndex = 64;
            this.labelMYNAME.Text = "20110081_Trương Phạm Lý Hương";
            // 
            // buttonAddScore
            // 
            this.buttonAddScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddScore.Location = new System.Drawing.Point(21, 369);
            this.buttonAddScore.Name = "buttonAddScore";
            this.buttonAddScore.Size = new System.Drawing.Size(470, 42);
            this.buttonAddScore.TabIndex = 63;
            this.buttonAddScore.Text = "Add Score";
            this.buttonAddScore.UseVisualStyleBackColor = true;
            this.buttonAddScore.Click += new System.EventHandler(this.buttonAddScore_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(197, 236);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(294, 113);
            this.textBoxDescription.TabIndex = 62;
            // 
            // textBoxScore
            // 
            this.textBoxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScore.Location = new System.Drawing.Point(197, 182);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(160, 30);
            this.textBoxScore.TabIndex = 61;
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentID.Location = new System.Drawing.Point(197, 25);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(152, 30);
            this.textBoxStudentID.TabIndex = 59;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDescription.Location = new System.Drawing.Point(42, 236);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(141, 29);
            this.labelDescription.TabIndex = 58;
            this.labelDescription.Text = "Description:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelScore.Location = new System.Drawing.Point(100, 182);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(83, 29);
            this.labelScore.TabIndex = 57;
            this.labelScore.Text = "Score:";
            // 
            // labelCourseID
            // 
            this.labelCourseID.AutoSize = true;
            this.labelCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCourseID.Location = new System.Drawing.Point(53, 26);
            this.labelCourseID.Name = "labelCourseID";
            this.labelCourseID.Size = new System.Drawing.Size(130, 29);
            this.labelCourseID.TabIndex = 55;
            this.labelCourseID.Text = "Student ID:";
            // 
            // stdBindingSource
            // 
            this.stdBindingSource.DataMember = "std";
            this.stdBindingSource.DataSource = this.qUANLYSINHVIENDataSet3;
            // 
            // qUANLYSINHVIENDataSet3
            // 
            this.qUANLYSINHVIENDataSet3.DataSetName = "QUANLYSINHVIENDataSet3";
            this.qUANLYSINHVIENDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stdTableAdapter
            // 
            this.stdTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxSemester.Location = new System.Drawing.Point(197, 78);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(68, 33);
            this.comboBoxSemester.TabIndex = 69;
            this.comboBoxSemester.SelectedValueChanged += new System.EventHandler(this.comboBoxSemester_SelectedValueChanged);
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemester.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSemester.Location = new System.Drawing.Point(60, 78);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(123, 29);
            this.labelSemester.TabIndex = 68;
            this.labelSemester.Text = "Semester:";
            // 
            // dataGridView_infoStudent
            // 
            this.dataGridView_infoStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_infoStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_infoStudent.Location = new System.Drawing.Point(517, 26);
            this.dataGridView_infoStudent.Name = "dataGridView_infoStudent";
            this.dataGridView_infoStudent.RowHeadersWidth = 51;
            this.dataGridView_infoStudent.RowTemplate.Height = 24;
            this.dataGridView_infoStudent.Size = new System.Drawing.Size(812, 385);
            this.dataGridView_infoStudent.TabIndex = 70;
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1341, 450);
            this.Controls.Add(this.dataGridView_infoStudent);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.comboSelectCourse);
            this.Controls.Add(this.labelSelectCourse);
            this.Controls.Add(this.labelMYNAME);
            this.Controls.Add(this.buttonAddScore);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelCourseID);
            this.Name = "AddScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddScoreForm";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYSINHVIENDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_infoStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSelectCourse;
        private System.Windows.Forms.Label labelSelectCourse;
        private System.Windows.Forms.Label labelMYNAME;
        private System.Windows.Forms.Button buttonAddScore;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelCourseID;
        private QUANLYSINHVIENDataSet3 qUANLYSINHVIENDataSet3;
        private System.Windows.Forms.BindingSource stdBindingSource;
        private QUANLYSINHVIENDataSet3TableAdapters.stdTableAdapter stdTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.DataGridView dataGridView_infoStudent;
    }
}