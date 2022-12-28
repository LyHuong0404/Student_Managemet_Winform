
namespace Quan_Ly_Sinh_Vien
{
    partial class UpdateDeleteStudentForm
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
            this.lb_studentid = new System.Windows.Forms.Label();
            this.lb_firstname = new System.Windows.Forms.Label();
            this.lb_lastname = new System.Windows.Forms.Label();
            this.lb_birthdate = new System.Windows.Forms.Label();
            this.lb_gender = new System.Windows.Forms.Label();
            this.lb_phone = new System.Windows.Forms.Label();
            this.lb_address = new System.Windows.Forms.Label();
            this.lb_picture = new System.Windows.Forms.Label();
            this.tb_studentid = new System.Windows.Forms.TextBox();
            this.tb_firstname = new System.Windows.Forms.TextBox();
            this.tb_lastname = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.bt_find = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.pictureBox_imageStudent = new System.Windows.Forms.PictureBox();
            this.bt_uploadImage = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_remove = new System.Windows.Forms.Button();
            this.bt_search = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelMYNAME = new System.Windows.Forms.Label();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imageStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_studentid
            // 
            this.lb_studentid.AutoSize = true;
            this.lb_studentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_studentid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_studentid.Location = new System.Drawing.Point(117, 19);
            this.lb_studentid.Name = "lb_studentid";
            this.lb_studentid.Size = new System.Drawing.Size(50, 32);
            this.lb_studentid.TabIndex = 0;
            this.lb_studentid.Text = "ID:";
            // 
            // lb_firstname
            // 
            this.lb_firstname.AutoSize = true;
            this.lb_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_firstname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_firstname.Location = new System.Drawing.Point(8, 72);
            this.lb_firstname.Name = "lb_firstname";
            this.lb_firstname.Size = new System.Drawing.Size(160, 32);
            this.lb_firstname.TabIndex = 1;
            this.lb_firstname.Text = "First Name:";
            // 
            // lb_lastname
            // 
            this.lb_lastname.AutoSize = true;
            this.lb_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lastname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_lastname.Location = new System.Drawing.Point(9, 133);
            this.lb_lastname.Name = "lb_lastname";
            this.lb_lastname.Size = new System.Drawing.Size(159, 32);
            this.lb_lastname.TabIndex = 2;
            this.lb_lastname.Text = "Last Name:";
            // 
            // lb_birthdate
            // 
            this.lb_birthdate.AutoSize = true;
            this.lb_birthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_birthdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_birthdate.Location = new System.Drawing.Point(25, 201);
            this.lb_birthdate.Name = "lb_birthdate";
            this.lb_birthdate.Size = new System.Drawing.Size(142, 32);
            this.lb_birthdate.TabIndex = 3;
            this.lb_birthdate.Text = "BirthDate:";
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_gender.Location = new System.Drawing.Point(49, 268);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(118, 32);
            this.lb_gender.TabIndex = 4;
            this.lb_gender.Text = "Gender:";
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_phone.Location = new System.Drawing.Point(61, 329);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(106, 32);
            this.lb_phone.TabIndex = 5;
            this.lb_phone.Text = "Phone:";
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_address.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_address.Location = new System.Drawing.Point(538, 12);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(127, 32);
            this.lb_address.TabIndex = 6;
            this.lb_address.Text = "Address:";
            // 
            // lb_picture
            // 
            this.lb_picture.AutoSize = true;
            this.lb_picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_picture.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_picture.Location = new System.Drawing.Point(550, 72);
            this.lb_picture.Name = "lb_picture";
            this.lb_picture.Size = new System.Drawing.Size(112, 32);
            this.lb_picture.TabIndex = 7;
            this.lb_picture.Text = "Picture:";
            // 
            // tb_studentid
            // 
            this.errorProvider1.SetError(this.tb_studentid, "Only Enter Number");
            this.tb_studentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_studentid.Location = new System.Drawing.Point(184, 13);
            this.tb_studentid.Name = "tb_studentid";
            this.tb_studentid.Size = new System.Drawing.Size(165, 34);
            this.tb_studentid.TabIndex = 8;
            this.tb_studentid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_studentid_KeyPress);
            // 
            // tb_firstname
            // 
            this.errorProvider2.SetError(this.tb_firstname, "Only Enter Char");
            this.tb_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_firstname.Location = new System.Drawing.Point(184, 70);
            this.tb_firstname.Name = "tb_firstname";
            this.tb_firstname.Size = new System.Drawing.Size(331, 34);
            this.tb_firstname.TabIndex = 9;
            this.tb_firstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_firstname_KeyPress);
            // 
            // tb_lastname
            // 
            this.errorProvider3.SetError(this.tb_lastname, "Only Enter Char");
            this.tb_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lastname.Location = new System.Drawing.Point(184, 131);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.Size = new System.Drawing.Size(331, 34);
            this.tb_lastname.TabIndex = 10;
            this.tb_lastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_lastname_KeyPress);
            // 
            // tb_phone
            // 
            this.errorProvider4.SetError(this.tb_phone, "Only Enter Number");
            this.tb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_phone.Location = new System.Drawing.Point(184, 329);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(331, 34);
            this.tb_phone.TabIndex = 11;
            this.tb_phone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_phone_KeyDown);
            this.tb_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_phone_KeyPress);
            // 
            // tb_address
            // 
            this.tb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_address.Location = new System.Drawing.Point(684, 6);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(296, 34);
            this.tb_address.TabIndex = 12;
            // 
            // bt_find
            // 
            this.bt_find.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_find.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_find.Location = new System.Drawing.Point(393, 9);
            this.bt_find.Name = "bt_find";
            this.bt_find.Size = new System.Drawing.Size(122, 37);
            this.bt_find.TabIndex = 13;
            this.bt_find.Text = "Find";
            this.bt_find.UseVisualStyleBackColor = false;
            this.bt_find.Click += new System.EventHandler(this.bt_find_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(184, 209);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(331, 30);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.radioButton_female);
            this.panel1.Controls.Add(this.radioButton_male);
            this.panel1.Location = new System.Drawing.Point(184, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 32);
            this.panel1.TabIndex = 15;
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_female.Location = new System.Drawing.Point(188, 4);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(98, 29);
            this.radioButton_female.TabIndex = 16;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_male.Location = new System.Drawing.Point(23, 4);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(76, 29);
            this.radioButton_male.TabIndex = 0;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Male";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // pictureBox_imageStudent
            // 
            this.pictureBox_imageStudent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox_imageStudent.Location = new System.Drawing.Point(684, 72);
            this.pictureBox_imageStudent.Name = "pictureBox_imageStudent";
            this.pictureBox_imageStudent.Size = new System.Drawing.Size(296, 177);
            this.pictureBox_imageStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_imageStudent.TabIndex = 16;
            this.pictureBox_imageStudent.TabStop = false;
            // 
            // bt_uploadImage
            // 
            this.bt_uploadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_uploadImage.Location = new System.Drawing.Point(544, 133);
            this.bt_uploadImage.Name = "bt_uploadImage";
            this.bt_uploadImage.Size = new System.Drawing.Size(118, 32);
            this.bt_uploadImage.TabIndex = 17;
            this.bt_uploadImage.Text = "Upload Image";
            this.bt_uploadImage.UseVisualStyleBackColor = true;
            this.bt_uploadImage.Click += new System.EventHandler(this.bt_uploadImage_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.BackColor = System.Drawing.Color.Aquamarine;
            this.bt_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_edit.Location = new System.Drawing.Point(31, 377);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(191, 61);
            this.bt_edit.TabIndex = 18;
            this.bt_edit.Text = "Edit";
            this.bt_edit.UseVisualStyleBackColor = false;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_remove
            // 
            this.bt_remove.BackColor = System.Drawing.Color.Red;
            this.bt_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_remove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_remove.Location = new System.Drawing.Point(300, 377);
            this.bt_remove.Name = "bt_remove";
            this.bt_remove.Size = new System.Drawing.Size(191, 61);
            this.bt_remove.TabIndex = 19;
            this.bt_remove.Text = "Remove";
            this.bt_remove.UseVisualStyleBackColor = false;
            this.bt_remove.Click += new System.EventHandler(this.bt_remove_Click);
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.Orange;
            this.bt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_search.Location = new System.Drawing.Point(770, 377);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(191, 61);
            this.bt_search.TabIndex = 20;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
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
            this.labelMYNAME.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMYNAME.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMYNAME.Location = new System.Drawing.Point(569, 449);
            this.labelMYNAME.Name = "labelMYNAME";
            this.labelMYNAME.Size = new System.Drawing.Size(360, 27);
            this.labelMYNAME.TabIndex = 39;
            this.labelMYNAME.Text = "20110081_Trương Phạm Lý Hương";
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.BackColor = System.Drawing.Color.Gold;
            this.buttonAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCourse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddCourse.Location = new System.Drawing.Point(543, 377);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(191, 61);
            this.buttonAddCourse.TabIndex = 41;
            this.buttonAddCourse.Text = "Add Course";
            this.buttonAddCourse.UseVisualStyleBackColor = false;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // UpdateDeleteStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(992, 485);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.labelMYNAME);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.bt_remove);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_uploadImage);
            this.Controls.Add(this.pictureBox_imageStudent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bt_find);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_lastname);
            this.Controls.Add(this.tb_firstname);
            this.Controls.Add(this.tb_studentid);
            this.Controls.Add(this.lb_picture);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.lb_gender);
            this.Controls.Add(this.lb_birthdate);
            this.Controls.Add(this.lb_lastname);
            this.Controls.Add(this.lb_firstname);
            this.Controls.Add(this.lb_studentid);
            this.Name = "UpdateDeleteStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdatedeleteStudentForm";
            this.Load += new System.EventHandler(this.UpdateDeleteStudentForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UpdateDeleteStudentForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imageStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_studentid;
        private System.Windows.Forms.Label lb_firstname;
        private System.Windows.Forms.Label lb_lastname;
        private System.Windows.Forms.Label lb_birthdate;
        private System.Windows.Forms.Label lb_gender;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_picture;
        public System.Windows.Forms.TextBox tb_studentid;
        public System.Windows.Forms.TextBox tb_firstname;
        public System.Windows.Forms.TextBox tb_lastname;
        public System.Windows.Forms.TextBox tb_phone;
        public System.Windows.Forms.TextBox tb_address;
        public System.Windows.Forms.Button bt_find;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.RadioButton radioButton_female;
        public System.Windows.Forms.RadioButton radioButton_male;
        public System.Windows.Forms.PictureBox pictureBox_imageStudent;
        private System.Windows.Forms.Button bt_uploadImage;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_remove;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label labelMYNAME;
        private System.Windows.Forms.Button buttonAddCourse;
    }
}