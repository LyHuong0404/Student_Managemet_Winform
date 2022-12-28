
namespace Quan_Ly_Sinh_Vien
{
    partial class AVGResultForm
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
            this.lb_Studentid = new System.Windows.Forms.Label();
            this.lb_fname = new System.Windows.Forms.Label();
            this.lb_lname = new System.Windows.Forms.Label();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelStudentResult = new System.Windows.Forms.Label();
            this.lableSemester = new System.Windows.Forms.Label();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.labelMYNAME = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.dataGridView_information = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_information)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Studentid
            // 
            this.lb_Studentid.AutoSize = true;
            this.lb_Studentid.BackColor = System.Drawing.Color.Transparent;
            this.lb_Studentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lb_Studentid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Studentid.Location = new System.Drawing.Point(42, 60);
            this.lb_Studentid.Name = "lb_Studentid";
            this.lb_Studentid.Size = new System.Drawing.Size(131, 29);
            this.lb_Studentid.TabIndex = 1;
            this.lb_Studentid.Text = "Student ID";
            // 
            // lb_fname
            // 
            this.lb_fname.AutoSize = true;
            this.lb_fname.BackColor = System.Drawing.Color.Transparent;
            this.lb_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lb_fname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_fname.Location = new System.Drawing.Point(41, 210);
            this.lb_fname.Name = "lb_fname";
            this.lb_fname.Size = new System.Drawing.Size(137, 29);
            this.lb_fname.TabIndex = 2;
            this.lb_fname.Text = "First Name";
            // 
            // lb_lname
            // 
            this.lb_lname.AutoSize = true;
            this.lb_lname.BackColor = System.Drawing.Color.Transparent;
            this.lb_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lb_lname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_lname.Location = new System.Drawing.Point(42, 298);
            this.lb_lname.Name = "lb_lname";
            this.lb_lname.Size = new System.Drawing.Size(136, 29);
            this.lb_lname.TabIndex = 3;
            this.lb_lname.Text = "Last Name";
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxStudentID.Location = new System.Drawing.Point(194, 60);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(183, 34);
            this.textBoxStudentID.TabIndex = 9;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxLastName.Location = new System.Drawing.Point(194, 293);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(183, 34);
            this.textBoxLastName.TabIndex = 10;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxFirstName.Location = new System.Drawing.Point(194, 205);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(183, 34);
            this.textBoxFirstName.TabIndex = 11;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.BackColor = System.Drawing.Color.Transparent;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSearch.Location = new System.Drawing.Point(24, 415);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(386, 29);
            this.labelSearch.TabIndex = 12;
            this.labelSearch.Text = "Search FName, LName, Address";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(194, 475);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(183, 38);
            this.textBoxSearch.TabIndex = 13;
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.LightCyan;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonPrint.Location = new System.Drawing.Point(1142, 519);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(149, 49);
            this.buttonPrint.TabIndex = 20;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.LightCyan;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonCancel.Location = new System.Drawing.Point(1314, 519);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(149, 45);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelStudentResult
            // 
            this.labelStudentResult.AutoSize = true;
            this.labelStudentResult.BackColor = System.Drawing.Color.Transparent;
            this.labelStudentResult.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentResult.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelStudentResult.Location = new System.Drawing.Point(425, -1);
            this.labelStudentResult.Name = "labelStudentResult";
            this.labelStudentResult.Size = new System.Drawing.Size(238, 44);
            this.labelStudentResult.TabIndex = 22;
            this.labelStudentResult.Text = "Student Result";
            // 
            // lableSemester
            // 
            this.lableSemester.AutoSize = true;
            this.lableSemester.BackColor = System.Drawing.Color.Transparent;
            this.lableSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lableSemester.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lableSemester.Location = new System.Drawing.Point(51, 133);
            this.lableSemester.Name = "lableSemester";
            this.lableSemester.Size = new System.Drawing.Size(122, 29);
            this.lableSemester.TabIndex = 24;
            this.lableSemester.Text = "Semester";
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxSemester.Location = new System.Drawing.Point(194, 129);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(79, 33);
            this.comboBoxSemester.TabIndex = 25;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.LightCyan;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonSearch.Location = new System.Drawing.Point(29, 468);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(149, 45);
            this.buttonSearch.TabIndex = 26;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
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
            this.labelMYNAME.Location = new System.Drawing.Point(1103, 569);
            this.labelMYNAME.Name = "labelMYNAME";
            this.labelMYNAME.Size = new System.Drawing.Size(360, 27);
            this.labelMYNAME.TabIndex = 40;
            this.labelMYNAME.Text = "20110081_Trương Phạm Lý Hương";
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.Color.LightCyan;
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonShow.Location = new System.Drawing.Point(424, 521);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(149, 49);
            this.buttonShow.TabIndex = 41;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // dataGridView_information
            // 
            this.dataGridView_information.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_information.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_information.Location = new System.Drawing.Point(433, 60);
            this.dataGridView_information.Name = "dataGridView_information";
            this.dataGridView_information.RowHeadersWidth = 51;
            this.dataGridView_information.RowTemplate.Height = 24;
            this.dataGridView_information.Size = new System.Drawing.Size(1039, 453);
            this.dataGridView_information.TabIndex = 23;
            this.dataGridView_information.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_information_CellDoubleClick);
            // 
            // AVGResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1683, 605);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.labelMYNAME);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.lableSemester);
            this.Controls.Add(this.dataGridView_information);
            this.Controls.Add(this.labelStudentResult);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.lb_lname);
            this.Controls.Add(this.lb_fname);
            this.Controls.Add(this.lb_Studentid);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "AVGResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVGResultForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_information)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Studentid;
        private System.Windows.Forms.Label lb_fname;
        private System.Windows.Forms.Label lb_lname;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelStudentResult;
        private System.Windows.Forms.Label lableSemester;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.Button buttonSearch;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label labelMYNAME;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.DataGridView dataGridView_information;
    }
}