
namespace Quan_Ly_Sinh_Vien
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_register = new System.Windows.Forms.Button();
            this.toolTip_Username = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_password = new System.Windows.Forms.ToolTip(this.components);
            this.labelMYNAME = new System.Windows.Forms.Label();
            this.radioButtonStudent = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonHR = new System.Windows.Forms.RadioButton();
            this.labelQuenPass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(30, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lb_username.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_username.Location = new System.Drawing.Point(24, 171);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(158, 33);
            this.lb_username.TabIndex = 1;
            this.lb_username.Text = "Username:";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lb_password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_password.Location = new System.Drawing.Point(24, 228);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(151, 33);
            this.lb_password.TabIndex = 2;
            this.lb_password.Text = "Password:";
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.tb_username.Location = new System.Drawing.Point(200, 164);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(299, 40);
            this.tb_username.TabIndex = 3;
            this.toolTip_Username.SetToolTip(this.tb_username, "Enter Your Username!!");
            this.tb_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_username_KeyDown);
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.tb_password.Location = new System.Drawing.Point(200, 221);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(299, 40);
            this.tb_password.TabIndex = 4;
            this.toolTip_password.SetToolTip(this.tb_password, "Enter Your Password!!");
            this.tb_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_password_KeyDown);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancel.Location = new System.Drawing.Point(369, 347);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(132, 46);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Turquoise;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_login.Location = new System.Drawing.Point(32, 347);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(143, 46);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(223, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "ACCOUT LOGIN";
            // 
            // bt_register
            // 
            this.bt_register.BackColor = System.Drawing.Color.Orange;
            this.bt_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.bt_register.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_register.Location = new System.Drawing.Point(191, 347);
            this.bt_register.Name = "bt_register";
            this.bt_register.Size = new System.Drawing.Size(161, 46);
            this.bt_register.TabIndex = 9;
            this.bt_register.Text = "Register";
            this.bt_register.UseVisualStyleBackColor = false;
            this.bt_register.Click += new System.EventHandler(this.bt_register_Click);
            // 
            // toolTip_Username
            // 
            this.toolTip_Username.AutomaticDelay = 0;
            this.toolTip_Username.AutoPopDelay = 5000;
            this.toolTip_Username.InitialDelay = 0;
            this.toolTip_Username.IsBalloon = true;
            this.toolTip_Username.ReshowDelay = 100;
            // 
            // toolTip_password
            // 
            this.toolTip_password.AutomaticDelay = 0;
            this.toolTip_password.AutoPopDelay = 5000;
            this.toolTip_password.InitialDelay = 0;
            this.toolTip_password.IsBalloon = true;
            this.toolTip_password.ReshowDelay = 100;
            // 
            // labelMYNAME
            // 
            this.labelMYNAME.AutoSize = true;
            this.labelMYNAME.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMYNAME.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMYNAME.Location = new System.Drawing.Point(139, 462);
            this.labelMYNAME.Name = "labelMYNAME";
            this.labelMYNAME.Size = new System.Drawing.Size(360, 27);
            this.labelMYNAME.TabIndex = 38;
            this.labelMYNAME.Text = "20110081_Trương Phạm Lý Hương";
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonStudent.Location = new System.Drawing.Point(3, 3);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(101, 29);
            this.radioButtonStudent.TabIndex = 39;
            this.radioButtonStudent.TabStop = true;
            this.radioButtonStudent.Text = "Student";
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.radioButtonHR);
            this.panel1.Controls.Add(this.radioButtonStudent);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(189, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 44);
            this.panel1.TabIndex = 40;
            // 
            // radioButtonHR
            // 
            this.radioButtonHR.AutoSize = true;
            this.radioButtonHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHR.Location = new System.Drawing.Point(115, 3);
            this.radioButtonHR.Name = "radioButtonHR";
            this.radioButtonHR.Size = new System.Drawing.Size(184, 29);
            this.radioButtonHR.TabIndex = 41;
            this.radioButtonHR.TabStop = true;
            this.radioButtonHR.Text = "Human Resource";
            this.radioButtonHR.UseVisualStyleBackColor = true;
            // 
            // labelQuenPass
            // 
            this.labelQuenPass.AutoSize = true;
            this.labelQuenPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuenPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelQuenPass.Location = new System.Drawing.Point(29, 414);
            this.labelQuenPass.Name = "labelQuenPass";
            this.labelQuenPass.Size = new System.Drawing.Size(161, 24);
            this.labelQuenPass.TabIndex = 41;
            this.labelQuenPass.Text = "Quên mật khẩu>>";
            this.labelQuenPass.Click += new System.EventHandler(this.labelQuenPass_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(541, 498);
            this.Controls.Add(this.labelQuenPass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelMYNAME);
            this.Controls.Add(this.bt_register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        public System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_login;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_register;
        private System.Windows.Forms.ToolTip toolTip_Username;
        private System.Windows.Forms.ToolTip toolTip_password;
        private System.Windows.Forms.Label labelMYNAME;
        private System.Windows.Forms.RadioButton radioButtonStudent;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.RadioButton radioButtonHR;
        private System.Windows.Forms.Label labelQuenPass;
    }
}

