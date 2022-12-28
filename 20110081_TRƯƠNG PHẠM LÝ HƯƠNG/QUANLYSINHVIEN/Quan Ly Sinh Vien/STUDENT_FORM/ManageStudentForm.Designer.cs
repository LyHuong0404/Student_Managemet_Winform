
namespace Quan_Ly_Sinh_Vien
{
    partial class ManageStudentForm
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
            this.lb_Studentid = new System.Windows.Forms.Label();
            this.lb_birthdate = new System.Windows.Forms.Label();
            this.lb_fname = new System.Windows.Forms.Label();
            this.lb_lname = new System.Windows.Forms.Label();
            this.lb_gender = new System.Windows.Forms.Label();
            this.lb_phone = new System.Windows.Forms.Label();
            this.lb_address = new System.Windows.Forms.Label();
            this.lb_Picture = new System.Windows.Forms.Label();
            this.button_UploadImage = new System.Windows.Forms.Button();
            this.textboxstudenid = new System.Windows.Forms.TextBox();
            this.textboxfname = new System.Windows.Forms.TextBox();
            this.textboxlname = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textboxAddress = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtoon_Female = new System.Windows.Forms.RadioButton();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.pictureBoxImageStudent = new System.Windows.Forms.PictureBox();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textboxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.DataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.labelTotal = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelMYNAME = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Studentid
            // 
            this.lb_Studentid.AutoSize = true;
            this.lb_Studentid.BackColor = System.Drawing.Color.Transparent;
            this.lb_Studentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lb_Studentid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Studentid.Location = new System.Drawing.Point(37, 20);
            this.lb_Studentid.Name = "lb_Studentid";
            this.lb_Studentid.Size = new System.Drawing.Size(131, 29);
            this.lb_Studentid.TabIndex = 1;
            this.lb_Studentid.Text = "Student ID";
            // 
            // lb_birthdate
            // 
            this.lb_birthdate.AutoSize = true;
            this.lb_birthdate.BackColor = System.Drawing.Color.Transparent;
            this.lb_birthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lb_birthdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_birthdate.Location = new System.Drawing.Point(50, 199);
            this.lb_birthdate.Name = "lb_birthdate";
            this.lb_birthdate.Size = new System.Drawing.Size(118, 29);
            this.lb_birthdate.TabIndex = 4;
            this.lb_birthdate.Text = "BirthDate";
            // 
            // lb_fname
            // 
            this.lb_fname.AutoSize = true;
            this.lb_fname.BackColor = System.Drawing.Color.Transparent;
            this.lb_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lb_fname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_fname.Location = new System.Drawing.Point(31, 76);
            this.lb_fname.Name = "lb_fname";
            this.lb_fname.Size = new System.Drawing.Size(137, 29);
            this.lb_fname.TabIndex = 5;
            this.lb_fname.Text = "First Name";
            // 
            // lb_lname
            // 
            this.lb_lname.AutoSize = true;
            this.lb_lname.BackColor = System.Drawing.Color.Transparent;
            this.lb_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lb_lname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_lname.Location = new System.Drawing.Point(32, 138);
            this.lb_lname.Name = "lb_lname";
            this.lb_lname.Size = new System.Drawing.Size(136, 29);
            this.lb_lname.TabIndex = 6;
            this.lb_lname.Text = "Last Name";
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.BackColor = System.Drawing.Color.Transparent;
            this.lb_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lb_gender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_gender.Location = new System.Drawing.Point(72, 254);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(96, 29);
            this.lb_gender.TabIndex = 7;
            this.lb_gender.Text = "Gender";
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.BackColor = System.Drawing.Color.Transparent;
            this.lb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lb_phone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_phone.Location = new System.Drawing.Point(82, 304);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(86, 29);
            this.lb_phone.TabIndex = 8;
            this.lb_phone.Text = "Phone";
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.BackColor = System.Drawing.Color.Transparent;
            this.lb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lb_address.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_address.Location = new System.Drawing.Point(62, 353);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(106, 29);
            this.lb_address.TabIndex = 9;
            this.lb_address.Text = "Address";
            // 
            // lb_Picture
            // 
            this.lb_Picture.AutoSize = true;
            this.lb_Picture.BackColor = System.Drawing.Color.Transparent;
            this.lb_Picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lb_Picture.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Picture.Location = new System.Drawing.Point(76, 467);
            this.lb_Picture.Name = "lb_Picture";
            this.lb_Picture.Size = new System.Drawing.Size(92, 29);
            this.lb_Picture.TabIndex = 10;
            this.lb_Picture.Text = "Picture";
            // 
            // button_UploadImage
            // 
            this.button_UploadImage.Location = new System.Drawing.Point(184, 616);
            this.button_UploadImage.Name = "button_UploadImage";
            this.button_UploadImage.Size = new System.Drawing.Size(151, 27);
            this.button_UploadImage.TabIndex = 17;
            this.button_UploadImage.Text = "Upload Image";
            this.button_UploadImage.UseVisualStyleBackColor = true;
            this.button_UploadImage.Click += new System.EventHandler(this.button_UploadImage_Click);
            // 
            // textboxstudenid
            // 
            this.errorProvider1.SetError(this.textboxstudenid, "Only Enter Number");
            this.textboxstudenid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textboxstudenid.Location = new System.Drawing.Point(184, 12);
            this.textboxstudenid.Name = "textboxstudenid";
            this.textboxstudenid.Size = new System.Drawing.Size(162, 34);
            this.textboxstudenid.TabIndex = 18;
            this.textboxstudenid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxstudenid_KeyPress);
            // 
            // textboxfname
            // 
            this.errorProvider2.SetError(this.textboxfname, "Only Enter Char");
            this.textboxfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textboxfname.Location = new System.Drawing.Point(184, 71);
            this.textboxfname.Name = "textboxfname";
            this.textboxfname.Size = new System.Drawing.Size(314, 34);
            this.textboxfname.TabIndex = 19;
            this.textboxfname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxfname_KeyPress);
            // 
            // textboxlname
            // 
            this.errorProvider3.SetError(this.textboxlname, "Only Enter Char");
            this.textboxlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textboxlname.Location = new System.Drawing.Point(184, 138);
            this.textboxlname.Name = "textboxlname";
            this.textboxlname.Size = new System.Drawing.Size(314, 34);
            this.textboxlname.TabIndex = 20;
            this.textboxlname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxlname_KeyPress);
            // 
            // textBoxPhone
            // 
            this.errorProvider4.SetError(this.textBoxPhone, "Only Enter Number");
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxPhone.Location = new System.Drawing.Point(184, 299);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(314, 34);
            this.textBoxPhone.TabIndex = 22;
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            // 
            // textboxAddress
            // 
            this.textboxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxAddress.Location = new System.Drawing.Point(184, 353);
            this.textboxAddress.Multiline = true;
            this.textboxAddress.Name = "textboxAddress";
            this.textboxAddress.Size = new System.Drawing.Size(314, 99);
            this.textboxAddress.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(184, 199);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(314, 26);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.Value = new System.DateTime(2022, 3, 23, 0, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.radioButtoon_Female);
            this.panel1.Controls.Add(this.radioButton_Male);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(184, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 35);
            this.panel1.TabIndex = 25;
            // 
            // radioButtoon_Female
            // 
            this.radioButtoon_Female.AutoSize = true;
            this.radioButtoon_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtoon_Female.Location = new System.Drawing.Point(167, 7);
            this.radioButtoon_Female.Name = "radioButtoon_Female";
            this.radioButtoon_Female.Size = new System.Drawing.Size(98, 29);
            this.radioButtoon_Female.TabIndex = 14;
            this.radioButtoon_Female.TabStop = true;
            this.radioButtoon_Female.Text = "Female";
            this.radioButtoon_Female.UseVisualStyleBackColor = true;
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButton_Male.Location = new System.Drawing.Point(23, 7);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(76, 29);
            this.radioButton_Male.TabIndex = 13;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "Male";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // pictureBoxImageStudent
            // 
            this.pictureBoxImageStudent.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBoxImageStudent.Location = new System.Drawing.Point(184, 469);
            this.pictureBoxImageStudent.Name = "pictureBoxImageStudent";
            this.pictureBoxImageStudent.Size = new System.Drawing.Size(314, 141);
            this.pictureBoxImageStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImageStudent.TabIndex = 26;
            this.pictureBoxImageStudent.TabStop = false;
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(341, 616);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(157, 27);
            this.buttonDownload.TabIndex = 27;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button_Add.Location = new System.Drawing.Point(12, 666);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(149, 49);
            this.button_Add.TabIndex = 28;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Turquoise;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonEdit.Location = new System.Drawing.Point(169, 666);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(149, 49);
            this.buttonEdit.TabIndex = 29;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonRemove.Location = new System.Drawing.Point(332, 666);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(149, 49);
            this.buttonRemove.TabIndex = 30;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Crimson;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonReset.Location = new System.Drawing.Point(501, 666);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(149, 49);
            this.buttonReset.TabIndex = 31;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.BackColor = System.Drawing.Color.Transparent;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSearch.Location = new System.Drawing.Point(536, 20);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(393, 29);
            this.labelSearch.TabIndex = 32;
            this.labelSearch.Text = "Search FName, LName, Address:";
            // 
            // textboxSearch
            // 
            this.textboxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textboxSearch.Location = new System.Drawing.Point(944, 18);
            this.textboxSearch.Name = "textboxSearch";
            this.textboxSearch.Size = new System.Drawing.Size(295, 34);
            this.textboxSearch.TabIndex = 33;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonSearch.Location = new System.Drawing.Point(1245, 15);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(149, 39);
            this.buttonSearch.TabIndex = 34;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // DataGridViewInfo
            // 
            this.DataGridViewInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewInfo.Location = new System.Drawing.Point(521, 71);
            this.DataGridViewInfo.Name = "DataGridViewInfo";
            this.DataGridViewInfo.RowHeadersWidth = 51;
            this.DataGridViewInfo.RowTemplate.Height = 24;
            this.DataGridViewInfo.Size = new System.Drawing.Size(941, 539);
            this.DataGridViewInfo.TabIndex = 35;
            this.DataGridViewInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewInfo_CellDoubleClick);
            this.DataGridViewInfo.Click += new System.EventHandler(this.DataGridViewInfo_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.BackColor = System.Drawing.Color.Orchid;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTotal.Location = new System.Drawing.Point(1152, 616);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(310, 56);
            this.labelTotal.TabIndex = 36;
            this.labelTotal.Text = "Total Student:";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // labelMYNAME
            // 
            this.labelMYNAME.AutoSize = true;
            this.labelMYNAME.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMYNAME.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMYNAME.Location = new System.Drawing.Point(841, 700);
            this.labelMYNAME.Name = "labelMYNAME";
            this.labelMYNAME.Size = new System.Drawing.Size(512, 36);
            this.labelMYNAME.TabIndex = 37;
            this.labelMYNAME.Text = "20110081_Trương Phạm Lý Hương";
            // 
            // ManageStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(1474, 745);
            this.Controls.Add(this.labelMYNAME);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.DataGridViewInfo);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textboxSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.pictureBoxImageStudent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textboxAddress);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textboxlname);
            this.Controls.Add(this.textboxfname);
            this.Controls.Add(this.textboxstudenid);
            this.Controls.Add(this.button_UploadImage);
            this.Controls.Add(this.lb_Picture);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.lb_gender);
            this.Controls.Add(this.lb_lname);
            this.Controls.Add(this.lb_fname);
            this.Controls.Add(this.lb_birthdate);
            this.Controls.Add(this.lb_Studentid);
            this.Name = "ManageStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageStudentForm";
            this.Load += new System.EventHandler(this.ManageStudentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Studentid;
        private System.Windows.Forms.Label lb_birthdate;
        private System.Windows.Forms.Label lb_fname;
        private System.Windows.Forms.Label lb_lname;
        private System.Windows.Forms.Label lb_gender;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_Picture;
        private System.Windows.Forms.Button button_UploadImage;
        private System.Windows.Forms.TextBox textboxstudenid;
        private System.Windows.Forms.TextBox textboxfname;
        private System.Windows.Forms.TextBox textboxlname;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textboxAddress;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtoon_Female;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.PictureBox pictureBoxImageStudent;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textboxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView DataGridViewInfo;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label labelMYNAME;
    }
}