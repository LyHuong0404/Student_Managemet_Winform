
namespace Quan_Ly_Sinh_Vien
{
    partial class PrintScoreForm
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
            this.dataGridViewinfor = new System.Windows.Forms.DataGridView();
            this.buttonPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewinfor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewinfor
            // 
            this.dataGridViewinfor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewinfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewinfor.Location = new System.Drawing.Point(27, 33);
            this.dataGridViewinfor.Name = "dataGridViewinfor";
            this.dataGridViewinfor.RowHeadersWidth = 51;
            this.dataGridViewinfor.RowTemplate.Height = 24;
            this.dataGridViewinfor.Size = new System.Drawing.Size(748, 348);
            this.dataGridViewinfor.TabIndex = 0;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(646, 387);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(129, 38);
            this.buttonPrint.TabIndex = 1;
            this.buttonPrint.Text = "PRINT";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // PrintScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.dataGridViewinfor);
            this.Name = "PrintScoreForm";
            this.Text = "PrintScoreForm";
            this.Load += new System.EventHandler(this.PrintScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewinfor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewinfor;
        private System.Windows.Forms.Button buttonPrint;
    }
}