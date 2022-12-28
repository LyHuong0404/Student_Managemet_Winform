
namespace Quan_Ly_Sinh_Vien
{
    partial class Edit_InfoHR
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
            this.labelMYNAME = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.labelCreate = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.button_UploadImage = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.lb_Picture = new System.Windows.Forms.Label();
            this.lb_lname = new System.Windows.Forms.Label();
            this.lb_fname = new System.Windows.Forms.Label();
            this.lableID = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.lablePassword = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.lableUname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMYNAME
            // 
            this.labelMYNAME.AutoSize = true;
            this.labelMYNAME.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMYNAME.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMYNAME.Location = new System.Drawing.Point(41, 625);
            this.labelMYNAME.Name = "labelMYNAME";
            this.labelMYNAME.Size = new System.Drawing.Size(360, 27);
            this.labelMYNAME.TabIndex = 56;
            this.labelMYNAME.Text = "20110081_Trương Phạm Lý Hương";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(80, 585);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "<<Have an accout? Login";
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxID.Enabled = false;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxID.Location = new System.Drawing.Point(177, 54);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(158, 34);
            this.textBoxID.TabIndex = 54;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxFName.Location = new System.Drawing.Point(177, 113);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(224, 34);
            this.textBoxFName.TabIndex = 53;
            this.textBoxFName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFName_KeyPress);
            // 
            // textBoxLName
            // 
            this.textBoxLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxLName.Location = new System.Drawing.Point(176, 170);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(225, 34);
            this.textBoxLName.TabIndex = 52;
            this.textBoxLName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLName_KeyPress);
            // 
            // labelCreate
            // 
            this.labelCreate.AutoSize = true;
            this.labelCreate.BackColor = System.Drawing.Color.Transparent;
            this.labelCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCreate.Location = new System.Drawing.Point(116, 9);
            this.labelCreate.Name = "labelCreate";
            this.labelCreate.Size = new System.Drawing.Size(200, 38);
            this.labelCreate.TabIndex = 49;
            this.labelCreate.Text = "Edit My Info";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.LightCyan;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonEdit.Location = new System.Drawing.Point(36, 535);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(365, 43);
            this.buttonEdit.TabIndex = 48;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // button_UploadImage
            // 
            this.button_UploadImage.Location = new System.Drawing.Point(177, 492);
            this.button_UploadImage.Name = "button_UploadImage";
            this.button_UploadImage.Size = new System.Drawing.Size(225, 27);
            this.button_UploadImage.TabIndex = 47;
            this.button_UploadImage.Text = "Upload Image";
            this.button_UploadImage.UseVisualStyleBackColor = true;
            this.button_UploadImage.Click += new System.EventHandler(this.button_UploadImage_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBoxImage.Location = new System.Drawing.Point(176, 345);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(226, 141);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 46;
            this.pictureBoxImage.TabStop = false;
            // 
            // lb_Picture
            // 
            this.lb_Picture.AutoSize = true;
            this.lb_Picture.BackColor = System.Drawing.Color.Transparent;
            this.lb_Picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lb_Picture.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Picture.Location = new System.Drawing.Point(26, 345);
            this.lb_Picture.Name = "lb_Picture";
            this.lb_Picture.Size = new System.Drawing.Size(99, 29);
            this.lb_Picture.TabIndex = 45;
            this.lb_Picture.Text = "Picture:";
            // 
            // lb_lname
            // 
            this.lb_lname.AutoSize = true;
            this.lb_lname.BackColor = System.Drawing.Color.Transparent;
            this.lb_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lb_lname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_lname.Location = new System.Drawing.Point(26, 175);
            this.lb_lname.Name = "lb_lname";
            this.lb_lname.Size = new System.Drawing.Size(143, 29);
            this.lb_lname.TabIndex = 42;
            this.lb_lname.Text = "Last Name:";
            // 
            // lb_fname
            // 
            this.lb_fname.AutoSize = true;
            this.lb_fname.BackColor = System.Drawing.Color.Transparent;
            this.lb_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lb_fname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_fname.Location = new System.Drawing.Point(26, 118);
            this.lb_fname.Name = "lb_fname";
            this.lb_fname.Size = new System.Drawing.Size(144, 29);
            this.lb_fname.TabIndex = 41;
            this.lb_fname.Text = "First Name:";
            // 
            // lableID
            // 
            this.lableID.AutoSize = true;
            this.lableID.BackColor = System.Drawing.Color.Transparent;
            this.lableID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lableID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lableID.Location = new System.Drawing.Point(31, 56);
            this.lableID.Name = "lableID";
            this.lableID.Size = new System.Drawing.Size(44, 29);
            this.lableID.TabIndex = 40;
            this.lableID.Text = "ID:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxPassword.Location = new System.Drawing.Point(176, 282);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(225, 34);
            this.textBoxPassword.TabIndex = 50;
            // 
            // lablePassword
            // 
            this.lablePassword.AutoSize = true;
            this.lablePassword.BackColor = System.Drawing.Color.Transparent;
            this.lablePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lablePassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lablePassword.Location = new System.Drawing.Point(26, 287);
            this.lablePassword.Name = "lablePassword";
            this.lablePassword.Size = new System.Drawing.Size(131, 29);
            this.lablePassword.TabIndex = 44;
            this.lablePassword.Text = "Password:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxUserName.Location = new System.Drawing.Point(177, 228);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(225, 34);
            this.textBoxUserName.TabIndex = 51;
            // 
            // lableUname
            // 
            this.lableUname.AutoSize = true;
            this.lableUname.BackColor = System.Drawing.Color.Transparent;
            this.lableUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lableUname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lableUname.Location = new System.Drawing.Point(26, 233);
            this.lableUname.Name = "lableUname";
            this.lableUname.Size = new System.Drawing.Size(141, 29);
            this.lableUname.TabIndex = 43;
            this.lableUname.Text = "UserName:";
            // 
            // Edit_InfoHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 592);
            this.Controls.Add(this.labelMYNAME);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelCreate);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.button_UploadImage);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.lb_Picture);
            this.Controls.Add(this.lablePassword);
            this.Controls.Add(this.lableUname);
            this.Controls.Add(this.lb_lname);
            this.Controls.Add(this.lb_fname);
            this.Controls.Add(this.lableID);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Edit_InfoHR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit_InfoHR";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelMYNAME;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxID;
        public System.Windows.Forms.TextBox textBoxFName;
        public System.Windows.Forms.TextBox textBoxLName;
        public System.Windows.Forms.Label labelCreate;
        public System.Windows.Forms.Button buttonEdit;
        public System.Windows.Forms.Button button_UploadImage;
        public System.Windows.Forms.PictureBox pictureBoxImage;
        public System.Windows.Forms.Label lb_Picture;
        public System.Windows.Forms.Label lb_lname;
        public System.Windows.Forms.Label lb_fname;
        public System.Windows.Forms.Label lableID;
        public System.Windows.Forms.TextBox textBoxPassword;
        public System.Windows.Forms.Label lablePassword;
        public System.Windows.Forms.TextBox textBoxUserName;
        public System.Windows.Forms.Label lableUname;
    }
}