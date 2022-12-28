
namespace Quan_Ly_Sinh_Vien
{
    partial class ProcessBar_login
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
            this.lb_ready = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelName = new System.Windows.Forms.Label();
            this.labelHR_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_ready
            // 
            this.lb_ready.AutoSize = true;
            this.lb_ready.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ready.Location = new System.Drawing.Point(34, 30);
            this.lb_ready.Name = "lb_ready";
            this.lb_ready.Size = new System.Drawing.Size(100, 29);
            this.lb_ready.TabIndex = 0;
            this.lb_ready.Text = "Ready...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(39, 77);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(9);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(293, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(153, 113);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(46, 17);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "label2";
            this.labelName.Visible = false;
            // 
            // labelHR_ID
            // 
            this.labelHR_ID.AutoSize = true;
            this.labelHR_ID.Location = new System.Drawing.Point(359, 113);
            this.labelHR_ID.Name = "labelHR_ID";
            this.labelHR_ID.Size = new System.Drawing.Size(46, 17);
            this.labelHR_ID.TabIndex = 3;
            this.labelHR_ID.Text = "label1";
            this.labelHR_ID.Visible = false;
            // 
            // ProcessBar_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 151);
            this.Controls.Add(this.labelHR_ID);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lb_ready);
            this.Name = "ProcessBar_login";
            this.Text = "ProcessBar_login";
            this.Load += new System.EventHandler(this.ProcessBar_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ready;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label labelName;
        public System.Windows.Forms.Label labelHR_ID;
    }
}