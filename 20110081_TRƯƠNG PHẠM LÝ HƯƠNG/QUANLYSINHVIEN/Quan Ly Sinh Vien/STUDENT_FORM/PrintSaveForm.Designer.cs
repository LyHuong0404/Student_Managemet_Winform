
namespace Quan_Ly_Sinh_Vien
{
    partial class PrintSaveForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Check = new System.Windows.Forms.Button();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.radioButton_all = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.labelAnd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_No = new System.Windows.Forms.RadioButton();
            this.radioButton_Yes = new System.Windows.Forms.RadioButton();
            this.label_usedaterange = new System.Windows.Forms.Label();
            this.button_Print = new System.Windows.Forms.Button();
            this.qUANLYSINHVIENDataSet = new Quan_Ly_Sinh_Vien.QUANLYSINHVIENDataSet();
            this.stdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stdTableAdapter = new Quan_Ly_Sinh_Vien.QUANLYSINHVIENDataSetTableAdapters.stdTableAdapter();
            this.dataGridView_information = new System.Windows.Forms.DataGridView();
            this.labelMYNAME = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.labelSave = new System.Windows.Forms.Label();
            this.comboBoxFileType = new System.Windows.Forms.ComboBox();
            this.buttonExport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYSINHVIENDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_information)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.button_Check);
            this.panel1.Controls.Add(this.radioButton_Female);
            this.panel1.Controls.Add(this.radioButton_Male);
            this.panel1.Controls.Add(this.radioButton_all);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 108);
            this.panel1.TabIndex = 0;
            // 
            // button_Check
            // 
            this.button_Check.BackColor = System.Drawing.Color.Lime;
            this.button_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Check.Location = new System.Drawing.Point(938, 40);
            this.button_Check.Name = "button_Check";
            this.button_Check.Size = new System.Drawing.Size(125, 45);
            this.button_Check.TabIndex = 4;
            this.button_Check.Text = "Check";
            this.button_Check.UseVisualStyleBackColor = false;
            this.button_Check.Click += new System.EventHandler(this.button_Check_Click);
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Female.Location = new System.Drawing.Point(194, 40);
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.Size = new System.Drawing.Size(98, 29);
            this.radioButton_Female.TabIndex = 3;
            this.radioButton_Female.TabStop = true;
            this.radioButton_Female.Text = "Female";
            this.radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Male.Location = new System.Drawing.Point(87, 40);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(76, 29);
            this.radioButton_Male.TabIndex = 2;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "Male";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // radioButton_all
            // 
            this.radioButton_all.AutoSize = true;
            this.radioButton_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_all.Location = new System.Drawing.Point(3, 40);
            this.radioButton_all.Name = "radioButton_all";
            this.radioButton_all.Size = new System.Drawing.Size(55, 29);
            this.radioButton_all.TabIndex = 1;
            this.radioButton_all.TabStop = true;
            this.radioButton_all.Text = "All";
            this.radioButton_all.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker_End);
            this.panel2.Controls.Add(this.dateTimePicker_Start);
            this.panel2.Controls.Add(this.labelAnd);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.radioButton_No);
            this.panel2.Controls.Add(this.radioButton_Yes);
            this.panel2.Controls.Add(this.label_usedaterange);
            this.panel2.Location = new System.Drawing.Point(336, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 100);
            this.panel2.TabIndex = 0;
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_End.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_End.Location = new System.Drawing.Point(437, 51);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(131, 30);
            this.dateTimePicker_End.TabIndex = 9;
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Start.Location = new System.Drawing.Point(218, 53);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(135, 30);
            this.dateTimePicker_Start.TabIndex = 8;
            // 
            // labelAnd
            // 
            this.labelAnd.AutoSize = true;
            this.labelAnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnd.Location = new System.Drawing.Point(369, 56);
            this.labelAnd.Name = "labelAnd";
            this.labelAnd.Size = new System.Drawing.Size(48, 25);
            this.labelAnd.TabIndex = 7;
            this.labelAnd.Text = "And";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Birthdate Between:";
            // 
            // radioButton_No
            // 
            this.radioButton_No.AutoSize = true;
            this.radioButton_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_No.Location = new System.Drawing.Point(437, 16);
            this.radioButton_No.Name = "radioButton_No";
            this.radioButton_No.Size = new System.Drawing.Size(58, 29);
            this.radioButton_No.TabIndex = 5;
            this.radioButton_No.TabStop = true;
            this.radioButton_No.Text = "No";
            this.radioButton_No.UseVisualStyleBackColor = true;
            this.radioButton_No.CheckedChanged += new System.EventHandler(this.radioButton_No_CheckedChanged);
            // 
            // radioButton_Yes
            // 
            this.radioButton_Yes.AutoSize = true;
            this.radioButton_Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Yes.Location = new System.Drawing.Point(218, 16);
            this.radioButton_Yes.Name = "radioButton_Yes";
            this.radioButton_Yes.Size = new System.Drawing.Size(67, 29);
            this.radioButton_Yes.TabIndex = 4;
            this.radioButton_Yes.TabStop = true;
            this.radioButton_Yes.Text = "Yes";
            this.radioButton_Yes.UseVisualStyleBackColor = true;
            this.radioButton_Yes.CheckedChanged += new System.EventHandler(this.radioButton_Yes_CheckedChanged);
            // 
            // label_usedaterange
            // 
            this.label_usedaterange.AutoSize = true;
            this.label_usedaterange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usedaterange.Location = new System.Drawing.Point(3, 20);
            this.label_usedaterange.Name = "label_usedaterange";
            this.label_usedaterange.Size = new System.Drawing.Size(166, 25);
            this.label_usedaterange.TabIndex = 0;
            this.label_usedaterange.Text = "Use Date Range: ";
            // 
            // button_Print
            // 
            this.button_Print.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Print.Location = new System.Drawing.Point(920, 527);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(168, 37);
            this.button_Print.TabIndex = 6;
            this.button_Print.Text = "To Printer";
            this.button_Print.UseVisualStyleBackColor = false;
            this.button_Print.Click += new System.EventHandler(this.button_Print_Click);
            // 
            // qUANLYSINHVIENDataSet
            // 
            this.qUANLYSINHVIENDataSet.DataSetName = "QUANLYSINHVIENDataSet";
            this.qUANLYSINHVIENDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stdBindingSource
            // 
            this.stdBindingSource.DataMember = "std";
            this.stdBindingSource.DataSource = this.qUANLYSINHVIENDataSet;
            // 
            // stdTableAdapter
            // 
            this.stdTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView_information
            // 
            this.dataGridView_information.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_information.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_information.Location = new System.Drawing.Point(12, 139);
            this.dataGridView_information.Name = "dataGridView_information";
            this.dataGridView_information.RowHeadersWidth = 51;
            this.dataGridView_information.RowTemplate.Height = 24;
            this.dataGridView_information.Size = new System.Drawing.Size(1076, 382);
            this.dataGridView_information.TabIndex = 7;
            // 
            // labelMYNAME
            // 
            this.labelMYNAME.AutoSize = true;
            this.labelMYNAME.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMYNAME.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMYNAME.Location = new System.Drawing.Point(684, 575);
            this.labelMYNAME.Name = "labelMYNAME";
            this.labelMYNAME.Size = new System.Drawing.Size(360, 27);
            this.labelMYNAME.TabIndex = 40;
            this.labelMYNAME.Text = "20110081_Trương Phạm Lý Hương";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // labelSave
            // 
            this.labelSave.AutoSize = true;
            this.labelSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSave.Location = new System.Drawing.Point(82, 535);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(109, 29);
            this.labelSave.TabIndex = 42;
            this.labelSave.Text = "Save To:";
            // 
            // comboBoxFileType
            // 
            this.comboBoxFileType.FormattingEnabled = true;
            this.comboBoxFileType.Location = new System.Drawing.Point(206, 540);
            this.comboBoxFileType.Name = "comboBoxFileType";
            this.comboBoxFileType.Size = new System.Drawing.Size(194, 24);
            this.comboBoxFileType.TabIndex = 43;
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.Location = new System.Drawing.Point(424, 531);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(134, 37);
            this.buttonExport.TabIndex = 44;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // PrintSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1104, 611);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.comboBoxFileType);
            this.Controls.Add(this.labelSave);
            this.Controls.Add(this.labelMYNAME);
            this.Controls.Add(this.dataGridView_information);
            this.Controls.Add(this.button_Print);
            this.Controls.Add(this.panel1);
            this.Name = "PrintSaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintSaveForm";
            this.Load += new System.EventHandler(this.PrintSaveForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYSINHVIENDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_information)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Check;
        private System.Windows.Forms.RadioButton radioButton_Female;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.RadioButton radioButton_all;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private System.Windows.Forms.Label labelAnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_No;
        private System.Windows.Forms.RadioButton radioButton_Yes;
        private System.Windows.Forms.Label label_usedaterange;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.Button button_Print;
        private QUANLYSINHVIENDataSet qUANLYSINHVIENDataSet;
        private System.Windows.Forms.BindingSource stdBindingSource;
        private QUANLYSINHVIENDataSetTableAdapters.stdTableAdapter stdTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView_information;
        private System.Windows.Forms.Label labelMYNAME;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label labelSave;
        private System.Windows.Forms.ComboBox comboBoxFileType;
        private System.Windows.Forms.Button buttonExport;
    }
}