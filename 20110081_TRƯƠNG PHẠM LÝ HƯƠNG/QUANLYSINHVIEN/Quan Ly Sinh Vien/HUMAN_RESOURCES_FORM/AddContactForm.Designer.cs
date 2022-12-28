
namespace Quan_Ly_Sinh_Vien
{
    partial class AddContactForm
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
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.UploadImage_Button = new System.Windows.Forms.Button();
            this.buttonAddContact = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.TextboxAddress = new System.Windows.Forms.TextBox();
            this.PictureBoxImage = new System.Windows.Forms.PictureBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textboxLName = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.Picture_Label = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.gr_cbb = new System.Windows.Forms.ComboBox();
            this.labelMYNAME = new System.Windows.Forms.Label();
            this.labelCreate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxContactID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(155, 271);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(355, 24);
            this.textBoxEmail.TabIndex = 85;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelEmail.Location = new System.Drawing.Point(71, 220);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(60, 25);
            this.labelEmail.TabIndex = 84;
            this.labelEmail.Text = "Email";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelGroup.Location = new System.Drawing.Point(65, 167);
            this.labelGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(66, 25);
            this.labelGroup.TabIndex = 83;
            this.labelGroup.Text = "Group";
            // 
            // UploadImage_Button
            // 
            this.UploadImage_Button.BackColor = System.Drawing.Color.White;
            this.UploadImage_Button.Location = new System.Drawing.Point(155, 556);
            this.UploadImage_Button.Margin = new System.Windows.Forms.Padding(4);
            this.UploadImage_Button.Name = "UploadImage_Button";
            this.UploadImage_Button.Size = new System.Drawing.Size(215, 28);
            this.UploadImage_Button.TabIndex = 82;
            this.UploadImage_Button.Text = "Upload Image";
            this.UploadImage_Button.UseVisualStyleBackColor = false;
            this.UploadImage_Button.Click += new System.EventHandler(this.UploadImage_Button_Click);
            // 
            // buttonAddContact
            // 
            this.buttonAddContact.BackColor = System.Drawing.Color.Lime;
            this.buttonAddContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonAddContact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddContact.Location = new System.Drawing.Point(76, 592);
            this.buttonAddContact.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddContact.Name = "buttonAddContact";
            this.buttonAddContact.Size = new System.Drawing.Size(160, 47);
            this.buttonAddContact.TabIndex = 81;
            this.buttonAddContact.Text = "Add Contact";
            this.buttonAddContact.UseVisualStyleBackColor = false;
            this.buttonAddContact.Click += new System.EventHandler(this.buttonAddContact_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancel.Location = new System.Drawing.Point(318, 592);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(155, 47);
            this.buttonCancel.TabIndex = 80;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // TextboxAddress
            // 
            this.TextboxAddress.Location = new System.Drawing.Point(155, 314);
            this.TextboxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxAddress.Multiline = true;
            this.TextboxAddress.Name = "TextboxAddress";
            this.TextboxAddress.Size = new System.Drawing.Size(355, 72);
            this.TextboxAddress.TabIndex = 79;
            this.TextboxAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextboxAddress_KeyPress);
            // 
            // PictureBoxImage
            // 
            this.PictureBoxImage.BackColor = System.Drawing.Color.MistyRose;
            this.PictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBoxImage.Location = new System.Drawing.Point(155, 413);
            this.PictureBoxImage.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxImage.Name = "PictureBoxImage";
            this.PictureBoxImage.Size = new System.Drawing.Size(215, 136);
            this.PictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxImage.TabIndex = 78;
            this.PictureBoxImage.TabStop = false;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(155, 224);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(355, 22);
            this.textBoxPhone.TabIndex = 77;
            // 
            // textboxLName
            // 
            this.textboxLName.Location = new System.Drawing.Point(155, 126);
            this.textboxLName.Margin = new System.Windows.Forms.Padding(4);
            this.textboxLName.Name = "textboxLName";
            this.textboxLName.Size = new System.Drawing.Size(355, 22);
            this.textboxLName.TabIndex = 76;
            this.textboxLName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxLName_KeyPress);
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(155, 85);
            this.textBoxFName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(245, 22);
            this.textBoxFName.TabIndex = 75;
            this.textBoxFName.TextChanged += new System.EventHandler(this.textBoxFName_TextChanged);
            this.textBoxFName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFName_KeyPress);
            // 
            // Picture_Label
            // 
            this.Picture_Label.AutoSize = true;
            this.Picture_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Picture_Label.Location = new System.Drawing.Point(62, 413);
            this.Picture_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Picture_Label.Name = "Picture_Label";
            this.Picture_Label.Size = new System.Drawing.Size(72, 25);
            this.Picture_Label.TabIndex = 74;
            this.Picture_Label.Text = "Picture";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelAddress.Location = new System.Drawing.Point(46, 267);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(85, 25);
            this.labelAddress.TabIndex = 73;
            this.labelAddress.Text = "Address";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelPhone.Location = new System.Drawing.Point(65, 314);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(69, 25);
            this.labelPhone.TabIndex = 72;
            this.labelPhone.Text = "Phone";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelLastName.Location = new System.Drawing.Point(29, 123);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(106, 25);
            this.labelLastName.TabIndex = 71;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelFirstName.Location = new System.Drawing.Point(29, 81);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(106, 25);
            this.labelFirstName.TabIndex = 70;
            this.labelFirstName.Text = "First Name";
            // 
            // gr_cbb
            // 
            this.gr_cbb.FormattingEnabled = true;
            this.gr_cbb.Location = new System.Drawing.Point(155, 171);
            this.gr_cbb.Name = "gr_cbb";
            this.gr_cbb.Size = new System.Drawing.Size(355, 24);
            this.gr_cbb.TabIndex = 90;
            // 
            // labelMYNAME
            // 
            this.labelMYNAME.AutoSize = true;
            this.labelMYNAME.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMYNAME.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMYNAME.Location = new System.Drawing.Point(136, 647);
            this.labelMYNAME.Name = "labelMYNAME";
            this.labelMYNAME.Size = new System.Drawing.Size(360, 27);
            this.labelMYNAME.TabIndex = 93;
            this.labelMYNAME.Text = "20110081_Trương Phạm Lý Hương";
            // 
            // labelCreate
            // 
            this.labelCreate.AutoSize = true;
            this.labelCreate.BackColor = System.Drawing.Color.Transparent;
            this.labelCreate.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCreate.Location = new System.Drawing.Point(169, -5);
            this.labelCreate.Name = "labelCreate";
            this.labelCreate.Size = new System.Drawing.Size(210, 45);
            this.labelCreate.TabIndex = 94;
            this.labelCreate.Text = "Add Contact";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(100, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 95;
            this.label1.Text = "ID";
            // 
            // textBoxContactID
            // 
            this.textBoxContactID.Location = new System.Drawing.Point(155, 44);
            this.textBoxContactID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContactID.Name = "textBoxContactID";
            this.textBoxContactID.Size = new System.Drawing.Size(245, 22);
            this.textBoxContactID.TabIndex = 96;
            this.textBoxContactID.TextChanged += new System.EventHandler(this.textBoxContactID_TextChanged);
            this.textBoxContactID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxContactID_KeyPress);
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 650);
            this.Controls.Add(this.textBoxContactID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCreate);
            this.Controls.Add(this.labelMYNAME);
            this.Controls.Add(this.gr_cbb);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.UploadImage_Button);
            this.Controls.Add(this.buttonAddContact);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.TextboxAddress);
            this.Controls.Add(this.PictureBoxImage);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textboxLName);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.Picture_Label);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Name = "AddContactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddContactForm";
            this.Load += new System.EventHandler(this.AddContactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Button UploadImage_Button;
        private System.Windows.Forms.Button buttonAddContact;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox TextboxAddress;
        private System.Windows.Forms.PictureBox PictureBoxImage;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textboxLName;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label Picture_Label;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.ComboBox gr_cbb;
        private System.Windows.Forms.Label labelMYNAME;
        private System.Windows.Forms.Label labelCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxContactID;
    }
}