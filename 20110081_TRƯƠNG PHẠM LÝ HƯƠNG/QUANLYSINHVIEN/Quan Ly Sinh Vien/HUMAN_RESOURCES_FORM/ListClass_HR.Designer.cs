
namespace Quan_Ly_Sinh_Vien
{
    partial class ListClass_HR
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
            this.labelListClass = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewClass = new System.Windows.Forms.DataGridView();
            this.labelContactID = new System.Windows.Forms.Label();
            this.labelContactName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).BeginInit();
            this.SuspendLayout();
            // 
            // labelListClass
            // 
            this.labelListClass.AutoSize = true;
            this.labelListClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelListClass.Location = new System.Drawing.Point(315, 30);
            this.labelListClass.Name = "labelListClass";
            this.labelListClass.Size = new System.Drawing.Size(126, 29);
            this.labelListClass.TabIndex = 8;
            this.labelListClass.Text = "List Class";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(25, 428);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(135, 37);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(176, 432);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(193, 33);
            this.textBoxSearch.TabIndex = 12;
            // 
            // dataGridViewClass
            // 
            this.dataGridViewClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClass.Location = new System.Drawing.Point(25, 132);
            this.dataGridViewClass.Name = "dataGridViewClass";
            this.dataGridViewClass.RowHeadersWidth = 51;
            this.dataGridViewClass.RowTemplate.Height = 24;
            this.dataGridViewClass.Size = new System.Drawing.Size(691, 290);
            this.dataGridViewClass.TabIndex = 13;
            this.dataGridViewClass.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClass_CellDoubleClick);
            // 
            // labelContactID
            // 
            this.labelContactID.AutoSize = true;
            this.labelContactID.Location = new System.Drawing.Point(608, 87);
            this.labelContactID.Name = "labelContactID";
            this.labelContactID.Size = new System.Drawing.Size(46, 17);
            this.labelContactID.TabIndex = 14;
            this.labelContactID.Text = "label1";
            this.labelContactID.Visible = false;
            // 
            // labelContactName
            // 
            this.labelContactName.AutoSize = true;
            this.labelContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelContactName.Location = new System.Drawing.Point(20, 75);
            this.labelContactName.Name = "labelContactName";
            this.labelContactName.Size = new System.Drawing.Size(235, 29);
            this.labelContactName.TabIndex = 15;
            this.labelContactName.Text = "LabelNameContact";
            // 
            // ListClass_HR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(745, 477);
            this.Controls.Add(this.labelContactName);
            this.Controls.Add(this.labelContactID);
            this.Controls.Add(this.dataGridViewClass);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelListClass);
            this.Name = "ListClass_HR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListClass_HR";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListClass;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        public System.Windows.Forms.DataGridView dataGridViewClass;
        public System.Windows.Forms.Label labelContactID;
        public System.Windows.Forms.Label labelContactName;
    }
}