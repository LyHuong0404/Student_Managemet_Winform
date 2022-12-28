
namespace Quan_Ly_Sinh_Vien
{
    partial class AddCourseFrm
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
            this.labelSemester = new System.Windows.Forms.Label();
            this.labelMYNAME = new System.Windows.Forms.Label();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.labelAvailableCourse = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listBoxAvailableCourse = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_CurrentCoursesRegistered = new System.Windows.Forms.DataGridView();
            this.buttonShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CurrentCoursesRegistered)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemester.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSemester.Location = new System.Drawing.Point(397, 20);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(123, 29);
            this.labelSemester.TabIndex = 52;
            this.labelSemester.Text = "Semester:";
            // 
            // labelMYNAME
            // 
            this.labelMYNAME.AutoSize = true;
            this.labelMYNAME.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMYNAME.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMYNAME.Location = new System.Drawing.Point(257, 599);
            this.labelMYNAME.Name = "labelMYNAME";
            this.labelMYNAME.Size = new System.Drawing.Size(360, 27);
            this.labelMYNAME.TabIndex = 51;
            this.labelMYNAME.Text = "20110081_Trương Phạm Lý Hương";
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCourse.Location = new System.Drawing.Point(129, 537);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(93, 42);
            this.buttonAddCourse.TabIndex = 50;
            this.buttonAddCourse.Text = "Add";
            this.buttonAddCourse.UseVisualStyleBackColor = false;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentID.Location = new System.Drawing.Point(148, 20);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(160, 30);
            this.textBoxStudentID.TabIndex = 46;
            this.textBoxStudentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStudentID_KeyPress);
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStudentID.Location = new System.Drawing.Point(12, 24);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(124, 29);
            this.labelStudentID.TabIndex = 42;
            this.labelStudentID.Text = "Student ID";
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxSemester.Location = new System.Drawing.Point(537, 21);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(80, 28);
            this.comboBoxSemester.TabIndex = 53;
            // 
            // labelAvailableCourse
            // 
            this.labelAvailableCourse.AutoSize = true;
            this.labelAvailableCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailableCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAvailableCourse.Location = new System.Drawing.Point(27, 274);
            this.labelAvailableCourse.Name = "labelAvailableCourse";
            this.labelAvailableCourse.Size = new System.Drawing.Size(195, 29);
            this.labelAvailableCourse.TabIndex = 54;
            this.labelAvailableCourse.Text = "Available Course";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(402, 537);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(93, 42);
            this.buttonSave.TabIndex = 56;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // listBoxAvailableCourse
            // 
            this.listBoxAvailableCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAvailableCourse.FormattingEnabled = true;
            this.listBoxAvailableCourse.ItemHeight = 26;
            this.listBoxAvailableCourse.Location = new System.Drawing.Point(16, 306);
            this.listBoxAvailableCourse.Name = "listBoxAvailableCourse";
            this.listBoxAvailableCourse.ScrollAlwaysVisible = true;
            this.listBoxAvailableCourse.Size = new System.Drawing.Size(624, 212);
            this.listBoxAvailableCourse.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(163, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 29);
            this.label1.TabIndex = 61;
            this.label1.Text = "List Of Currently Registered Courses";
            // 
            // dataGridView_CurrentCoursesRegistered
            // 
            this.dataGridView_CurrentCoursesRegistered.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_CurrentCoursesRegistered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CurrentCoursesRegistered.Location = new System.Drawing.Point(17, 107);
            this.dataGridView_CurrentCoursesRegistered.Name = "dataGridView_CurrentCoursesRegistered";
            this.dataGridView_CurrentCoursesRegistered.RowHeadersWidth = 51;
            this.dataGridView_CurrentCoursesRegistered.RowTemplate.Height = 24;
            this.dataGridView_CurrentCoursesRegistered.Size = new System.Drawing.Size(623, 164);
            this.dataGridView_CurrentCoursesRegistered.TabIndex = 62;
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.Location = new System.Drawing.Point(17, 65);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(109, 36);
            this.buttonShow.TabIndex = 63;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // AddCourseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(663, 635);
            this.Controls.Add(this.dataGridView_CurrentCoursesRegistered);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAvailableCourse);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelAvailableCourse);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.labelMYNAME);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.labelStudentID);
            this.Name = "AddCourseFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCourseForm";
            this.Load += new System.EventHandler(this.AddCourseFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CurrentCoursesRegistered)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.Label labelMYNAME;
        private System.Windows.Forms.Button buttonAddCourse;
        public System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.Label labelAvailableCourse;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListBox listBoxAvailableCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_CurrentCoursesRegistered;
        private System.Windows.Forms.Button buttonShow;
    }
}