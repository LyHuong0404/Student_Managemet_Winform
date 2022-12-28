
namespace Quan_Ly_Sinh_Vien
{
    partial class ManageCourseForm
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
            this.textBoxCourseID = new System.Windows.Forms.TextBox();
            this.label_Lable = new System.Windows.Forms.Label();
            this.textBoxLable = new System.Windows.Forms.TextBox();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.listBoxCourse = new System.Windows.Forms.ListBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.labelSemester = new System.Windows.Forms.Label();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCourseID
            // 
            this.labelCourseID.AutoSize = true;
            this.labelCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCourseID.Location = new System.Drawing.Point(25, 43);
            this.labelCourseID.Name = "labelCourseID";
            this.labelCourseID.Size = new System.Drawing.Size(126, 29);
            this.labelCourseID.TabIndex = 1;
            this.labelCourseID.Text = "Course ID:";
            // 
            // textBoxCourseID
            // 
            this.textBoxCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCourseID.Location = new System.Drawing.Point(180, 42);
            this.textBoxCourseID.Name = "textBoxCourseID";
            this.textBoxCourseID.Size = new System.Drawing.Size(302, 30);
            this.textBoxCourseID.TabIndex = 5;
            // 
            // label_Lable
            // 
            this.label_Lable.AutoSize = true;
            this.label_Lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Lable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Lable.Location = new System.Drawing.Point(72, 142);
            this.label_Lable.Name = "label_Lable";
            this.label_Lable.Size = new System.Drawing.Size(79, 29);
            this.label_Lable.TabIndex = 6;
            this.label_Lable.Text = "Lable:";
            // 
            // textBoxLable
            // 
            this.textBoxLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLable.Location = new System.Drawing.Point(180, 142);
            this.textBoxLable.Name = "textBoxLable";
            this.textBoxLable.Size = new System.Drawing.Size(302, 30);
            this.textBoxLable.TabIndex = 7;
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeriod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPeriod.Location = new System.Drawing.Point(60, 194);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(91, 29);
            this.labelPeriod.TabIndex = 8;
            this.labelPeriod.Text = "Period:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDescription.Location = new System.Drawing.Point(10, 241);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(141, 29);
            this.labelDescription.TabIndex = 10;
            this.labelDescription.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(180, 241);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(302, 144);
            this.textBoxDescription.TabIndex = 11;
            // 
            // buttonFirst
            // 
            this.buttonFirst.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFirst.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFirst.Location = new System.Drawing.Point(3, 405);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(109, 41);
            this.buttonFirst.TabIndex = 12;
            this.buttonFirst.Text = "First";
            this.buttonFirst.UseVisualStyleBackColor = false;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            this.buttonFirst.MouseLeave += new System.EventHandler(this.buttonFirst_MouseLeave);
            this.buttonFirst.MouseHover += new System.EventHandler(this.buttonFirst_MouseHover);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonNext.Location = new System.Drawing.Point(121, 405);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(109, 41);
            this.buttonNext.TabIndex = 13;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            this.buttonNext.MouseLeave += new System.EventHandler(this.buttonNext_MouseLeave);
            this.buttonNext.MouseHover += new System.EventHandler(this.buttonNext_MouseHover);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrevious.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPrevious.Location = new System.Drawing.Point(236, 407);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(124, 39);
            this.buttonPrevious.TabIndex = 14;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            this.buttonPrevious.MouseLeave += new System.EventHandler(this.buttonPrevious_MouseLeave);
            this.buttonPrevious.MouseHover += new System.EventHandler(this.buttonPrevious_MouseHover);
            // 
            // buttonLast
            // 
            this.buttonLast.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLast.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLast.Location = new System.Drawing.Point(366, 407);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(109, 41);
            this.buttonLast.TabIndex = 15;
            this.buttonLast.Text = "Last";
            this.buttonLast.UseVisualStyleBackColor = false;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            this.buttonLast.MouseLeave += new System.EventHandler(this.buttonLast_MouseLeave);
            this.buttonLast.MouseHover += new System.EventHandler(this.buttonLast_MouseHover);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Orange;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(42, 479);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(109, 41);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEdit.Location = new System.Drawing.Point(180, 479);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(109, 41);
            this.buttonEdit.TabIndex = 17;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Red;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRemove.Location = new System.Drawing.Point(317, 479);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(122, 41);
            this.buttonRemove.TabIndex = 18;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // listBoxCourse
            // 
            this.listBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCourse.FormattingEnabled = true;
            this.listBoxCourse.ItemHeight = 29;
            this.listBoxCourse.Location = new System.Drawing.Point(519, 42);
            this.listBoxCourse.Name = "listBoxCourse";
            this.listBoxCourse.Size = new System.Drawing.Size(313, 410);
            this.listBoxCourse.TabIndex = 19;
            this.listBoxCourse.SelectedIndexChanged += new System.EventHandler(this.listBoxCourse_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTotal.Location = new System.Drawing.Point(580, 479);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(243, 51);
            this.labelTotal.TabIndex = 20;
            this.labelTotal.Text = "Total Courses: ";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown.Location = new System.Drawing.Point(180, 195);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(153, 30);
            this.numericUpDown.TabIndex = 21;
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemester.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSemester.Location = new System.Drawing.Point(28, 91);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(123, 29);
            this.labelSemester.TabIndex = 42;
            this.labelSemester.Text = "Semester:";
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxSemester.Location = new System.Drawing.Point(180, 91);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(66, 28);
            this.comboBoxSemester.TabIndex = 55;
            // 
            // ManageCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(857, 546);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.listBoxCourse);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.textBoxLable);
            this.Controls.Add(this.label_Lable);
            this.Controls.Add(this.textBoxCourseID);
            this.Controls.Add(this.labelCourseID);
            this.Name = "ManageCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCourseForm";
            this.Load += new System.EventHandler(this.ManageCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCourseID;
        private System.Windows.Forms.TextBox textBoxCourseID;
        private System.Windows.Forms.Label label_Lable;
        private System.Windows.Forms.TextBox textBoxLable;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ListBox listBoxCourse;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.ComboBox comboBoxSemester;
    }
}