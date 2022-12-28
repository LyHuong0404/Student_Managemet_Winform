
namespace Quan_Ly_Sinh_Vien
{
    partial class EditCousreForm
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
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.label_Label = new System.Windows.Forms.Label();
            this.labelCourseID = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.numericUpDownPeriod = new System.Windows.Forms.NumericUpDown();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemester.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSemester.Location = new System.Drawing.Point(370, 24);
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
            this.labelMYNAME.Location = new System.Drawing.Point(177, 414);
            this.labelMYNAME.Name = "labelMYNAME";
            this.labelMYNAME.Size = new System.Drawing.Size(360, 27);
            this.labelMYNAME.TabIndex = 51;
            this.labelMYNAME.Text = "20110081_Trương Phạm Lý Hương";
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCourse.Location = new System.Drawing.Point(69, 356);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(486, 42);
            this.buttonAddCourse.TabIndex = 50;
            this.buttonAddCourse.Text = "Edit Course";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonEditCourse_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(211, 192);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(344, 144);
            this.textBoxDescription.TabIndex = 49;
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLabel.Location = new System.Drawing.Point(211, 74);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(344, 30);
            this.textBoxLabel.TabIndex = 47;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDescription.Location = new System.Drawing.Point(64, 182);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(141, 29);
            this.labelDescription.TabIndex = 45;
            this.labelDescription.Text = "Description:";
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeriod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPeriod.Location = new System.Drawing.Point(114, 129);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(91, 29);
            this.labelPeriod.TabIndex = 44;
            this.labelPeriod.Text = "Period:";
            // 
            // label_Label
            // 
            this.label_Label.AutoSize = true;
            this.label_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Label.Location = new System.Drawing.Point(126, 74);
            this.label_Label.Name = "label_Label";
            this.label_Label.Size = new System.Drawing.Size(79, 29);
            this.label_Label.TabIndex = 43;
            this.label_Label.Text = "Label:";
            // 
            // labelCourseID
            // 
            this.labelCourseID.AutoSize = true;
            this.labelCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCourseID.Location = new System.Drawing.Point(34, 24);
            this.labelCourseID.Name = "labelCourseID";
            this.labelCourseID.Size = new System.Drawing.Size(171, 29);
            this.labelCourseID.TabIndex = 42;
            this.labelCourseID.Text = "Select Course:";
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(211, 20);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(153, 33);
            this.comboBoxCourse.TabIndex = 53;
            this.comboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourse_SelectedIndexChanged);
            // 
            // numericUpDownPeriod
            // 
            this.numericUpDownPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPeriod.Location = new System.Drawing.Point(211, 137);
            this.numericUpDownPeriod.Name = "numericUpDownPeriod";
            this.numericUpDownPeriod.Size = new System.Drawing.Size(153, 30);
            this.numericUpDownPeriod.TabIndex = 54;
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxSemester.Location = new System.Drawing.Point(499, 24);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(56, 28);
            this.comboBoxSemester.TabIndex = 55;
            // 
            // EditCousreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.numericUpDownPeriod);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.labelMYNAME);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.label_Label);
            this.Controls.Add(this.labelCourseID);
            this.Name = "EditCousreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCourseForm";
            this.Load += new System.EventHandler(this.EditCousreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.Label labelMYNAME;
        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.Label label_Label;
        private System.Windows.Forms.Label labelCourseID;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.NumericUpDown numericUpDownPeriod;
        private System.Windows.Forms.ComboBox comboBoxSemester;
    }
}