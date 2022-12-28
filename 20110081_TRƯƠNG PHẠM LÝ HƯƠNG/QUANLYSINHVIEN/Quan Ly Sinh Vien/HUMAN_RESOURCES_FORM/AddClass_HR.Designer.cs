
namespace Quan_Ly_Sinh_Vien
{
    partial class AddClass_HR
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
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.labelSemester = new System.Windows.Forms.Label();
            this.labelSelectCourse = new System.Windows.Forms.Label();
            this.buttonAddClass = new System.Windows.Forms.Button();
            this.dataGridViewClass = new System.Windows.Forms.DataGridView();
            this.comboBoxContactID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboSelectCourse = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCreate
            // 
            this.labelCreate.AutoSize = true;
            this.labelCreate.BackColor = System.Drawing.Color.Transparent;
            this.labelCreate.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCreate.Location = new System.Drawing.Point(215, 20);
            this.labelCreate.Name = "labelCreate";
            this.labelCreate.Size = new System.Drawing.Size(175, 45);
            this.labelCreate.TabIndex = 95;
            this.labelCreate.Text = "Add Class";
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxSemester.Location = new System.Drawing.Point(211, 128);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(189, 33);
            this.comboBoxSemester.TabIndex = 102;
            this.comboBoxSemester.SelectedValueChanged += new System.EventHandler(this.comboBoxSemester_SelectedValueChanged);
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemester.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSemester.Location = new System.Drawing.Point(35, 128);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(123, 29);
            this.labelSemester.TabIndex = 101;
            this.labelSemester.Text = "Semester:";
            // 
            // labelSelectCourse
            // 
            this.labelSelectCourse.AutoSize = true;
            this.labelSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectCourse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSelectCourse.Location = new System.Drawing.Point(35, 180);
            this.labelSelectCourse.Name = "labelSelectCourse";
            this.labelSelectCourse.Size = new System.Drawing.Size(171, 29);
            this.labelSelectCourse.TabIndex = 99;
            this.labelSelectCourse.Text = "Select Course:";
            // 
            // buttonAddClass
            // 
            this.buttonAddClass.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddClass.Location = new System.Drawing.Point(35, 496);
            this.buttonAddClass.Name = "buttonAddClass";
            this.buttonAddClass.Size = new System.Drawing.Size(517, 42);
            this.buttonAddClass.TabIndex = 98;
            this.buttonAddClass.Text = "Add Class";
            this.buttonAddClass.UseVisualStyleBackColor = false;
            this.buttonAddClass.Click += new System.EventHandler(this.buttonAddClass_Click);
            // 
            // dataGridViewClass
            // 
            this.dataGridViewClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClass.Location = new System.Drawing.Point(35, 235);
            this.dataGridViewClass.Name = "dataGridViewClass";
            this.dataGridViewClass.RowHeadersWidth = 51;
            this.dataGridViewClass.RowTemplate.Height = 24;
            this.dataGridViewClass.Size = new System.Drawing.Size(517, 255);
            this.dataGridViewClass.TabIndex = 103;
            // 
            // comboBoxContactID
            // 
            this.comboBoxContactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxContactID.FormattingEnabled = true;
            this.comboBoxContactID.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxContactID.Location = new System.Drawing.Point(211, 82);
            this.comboBoxContactID.Name = "comboBoxContactID";
            this.comboBoxContactID.Size = new System.Drawing.Size(189, 33);
            this.comboBoxContactID.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(35, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 104;
            this.label1.Text = "Contact ID:";
            // 
            // comboSelectCourse
            // 
            this.comboSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSelectCourse.FormattingEnabled = true;
            this.comboSelectCourse.Location = new System.Drawing.Point(211, 180);
            this.comboSelectCourse.Name = "comboSelectCourse";
            this.comboSelectCourse.Size = new System.Drawing.Size(189, 33);
            this.comboSelectCourse.TabIndex = 106;
            // 
            // AddClass_HR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(578, 550);
            this.Controls.Add(this.comboSelectCourse);
            this.Controls.Add(this.comboBoxContactID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewClass);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.labelSelectCourse);
            this.Controls.Add(this.buttonAddClass);
            this.Controls.Add(this.labelCreate);
            this.Name = "AddClass_HR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddClass_HR";
            this.Load += new System.EventHandler(this.AddClass_HR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCreate;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.Label labelSelectCourse;
        private System.Windows.Forms.Button buttonAddClass;
        private System.Windows.Forms.DataGridView dataGridViewClass;
        private System.Windows.Forms.ComboBox comboBoxContactID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSelectCourse;
    }
}