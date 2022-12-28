
namespace Quan_Ly_Sinh_Vien
{
    partial class PrintCourseForm
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
            this.buttonPrint = new System.Windows.Forms.Button();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYSINHVIENDataSet2 = new Quan_Ly_Sinh_Vien.QUANLYSINHVIENDataSet2();
            this.courseTableAdapter = new Quan_Ly_Sinh_Vien.QUANLYSINHVIENDataSet2TableAdapters.CourseTableAdapter();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.labelSave = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonExport = new System.Windows.Forms.Button();
            this.courseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYSINHVIENDataSet4 = new Quan_Ly_Sinh_Vien.QUANLYSINHVIENDataSet4();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYSINHVIENDataSet21 = new Quan_Ly_Sinh_Vien.QUANLYSINHVIENDataSet2();
            this.courseTableAdapter1 = new Quan_Ly_Sinh_Vien.QUANLYSINHVIENDataSet4TableAdapters.CourseTableAdapter();
            this.labelMYNAME = new System.Windows.Forms.Label();
            this.dataGridView_information = new System.Windows.Forms.DataGridView();
            this.qUANLYSINHVIENDataSet5 = new Quan_Ly_Sinh_Vien.QUANLYSINHVIENDataSet5();
            this.courseBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter2 = new Quan_Ly_Sinh_Vien.QUANLYSINHVIENDataSet5TableAdapters.CourseTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYSINHVIENDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYSINHVIENDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYSINHVIENDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_information)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYSINHVIENDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPrint.Location = new System.Drawing.Point(747, 374);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(133, 40);
            this.buttonPrint.TabIndex = 18;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.qUANLYSINHVIENDataSet2;
            // 
            // qUANLYSINHVIENDataSet2
            // 
            this.qUANLYSINHVIENDataSet2.DataSetName = "QUANLYSINHVIENDataSet2";
            this.qUANLYSINHVIENDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // labelSave
            // 
            this.labelSave.AutoSize = true;
            this.labelSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSave.Location = new System.Drawing.Point(21, 385);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(109, 29);
            this.labelSave.TabIndex = 43;
            this.labelSave.Text = "Save To:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(151, 381);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 33);
            this.comboBox1.TabIndex = 44;
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.Location = new System.Drawing.Point(336, 374);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(152, 40);
            this.buttonExport.TabIndex = 45;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // courseBindingSource2
            // 
            this.courseBindingSource2.DataMember = "Course";
            this.courseBindingSource2.DataSource = this.qUANLYSINHVIENDataSet4;
            // 
            // qUANLYSINHVIENDataSet4
            // 
            this.qUANLYSINHVIENDataSet4.DataSetName = "QUANLYSINHVIENDataSet4";
            this.qUANLYSINHVIENDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataMember = "Course";
            this.courseBindingSource1.DataSource = this.qUANLYSINHVIENDataSet21;
            // 
            // qUANLYSINHVIENDataSet21
            // 
            this.qUANLYSINHVIENDataSet21.DataSetName = "QUANLYSINHVIENDataSet2";
            this.qUANLYSINHVIENDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTableAdapter1
            // 
            this.courseTableAdapter1.ClearBeforeFill = true;
            // 
            // labelMYNAME
            // 
            this.labelMYNAME.AutoSize = true;
            this.labelMYNAME.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMYNAME.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMYNAME.Location = new System.Drawing.Point(495, 435);
            this.labelMYNAME.Name = "labelMYNAME";
            this.labelMYNAME.Size = new System.Drawing.Size(360, 27);
            this.labelMYNAME.TabIndex = 47;
            this.labelMYNAME.Text = "20110081_Trương Phạm Lý Hương";
            // 
            // dataGridView_information
            // 
            this.dataGridView_information.AutoGenerateColumns = false;
            this.dataGridView_information.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_information.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_information.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.lableDataGridViewTextBoxColumn,
            this.periodDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn});
            this.dataGridView_information.DataSource = this.courseBindingSource3;
            this.dataGridView_information.Location = new System.Drawing.Point(26, 26);
            this.dataGridView_information.Name = "dataGridView_information";
            this.dataGridView_information.RowHeadersWidth = 51;
            this.dataGridView_information.RowTemplate.Height = 24;
            this.dataGridView_information.Size = new System.Drawing.Size(854, 333);
            this.dataGridView_information.TabIndex = 48;
            // 
            // qUANLYSINHVIENDataSet5
            // 
            this.qUANLYSINHVIENDataSet5.DataSetName = "QUANLYSINHVIENDataSet5";
            this.qUANLYSINHVIENDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource3
            // 
            this.courseBindingSource3.DataMember = "Course";
            this.courseBindingSource3.DataSource = this.qUANLYSINHVIENDataSet5;
            // 
            // courseTableAdapter2
            // 
            this.courseTableAdapter2.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "CourseID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // lableDataGridViewTextBoxColumn
            // 
            this.lableDataGridViewTextBoxColumn.DataPropertyName = "lable";
            this.lableDataGridViewTextBoxColumn.HeaderText = "CourseName";
            this.lableDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lableDataGridViewTextBoxColumn.Name = "lableDataGridViewTextBoxColumn";
            // 
            // periodDataGridViewTextBoxColumn
            // 
            this.periodDataGridViewTextBoxColumn.DataPropertyName = "period";
            this.periodDataGridViewTextBoxColumn.HeaderText = "Period";
            this.periodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.periodDataGridViewTextBoxColumn.Name = "periodDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Semester";
            this.semesterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            // 
            // PrintCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(905, 471);
            this.Controls.Add(this.dataGridView_information);
            this.Controls.Add(this.labelMYNAME);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelSave);
            this.Controls.Add(this.buttonPrint);
            this.Name = "PrintCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintCourseForm";
            this.Load += new System.EventHandler(this.PrintCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYSINHVIENDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYSINHVIENDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYSINHVIENDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_information)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYSINHVIENDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPrint;
        private QUANLYSINHVIENDataSet2 qUANLYSINHVIENDataSet2;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private QUANLYSINHVIENDataSet2TableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label labelSave;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonExport;
        private QUANLYSINHVIENDataSet2 qUANLYSINHVIENDataSet21;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private QUANLYSINHVIENDataSet4 qUANLYSINHVIENDataSet4;
        private System.Windows.Forms.BindingSource courseBindingSource2;
        private QUANLYSINHVIENDataSet4TableAdapters.CourseTableAdapter courseTableAdapter1;
        private System.Windows.Forms.Label labelMYNAME;
        private System.Windows.Forms.DataGridView dataGridView_information;
        private QUANLYSINHVIENDataSet5 qUANLYSINHVIENDataSet5;
        private System.Windows.Forms.BindingSource courseBindingSource3;
        private QUANLYSINHVIENDataSet5TableAdapters.CourseTableAdapter courseTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
    }
}