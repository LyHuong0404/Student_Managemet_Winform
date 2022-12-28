using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Sinh_Vien
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }
        STUDENTS student = new STUDENTS();
        private void StudentListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYSINHVIENDataSet1.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter.Fill(this.qUANLYSINHVIENDataSet1.std);

            SqlCommand command = new SqlCommand("SELECT * FROM std");
            DataGridView1.ReadOnly = true;

            //Xử lý hình ảnh (tham khảo MSDN)
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();   //doi tuong lam viec voi dang picture cua datagridview
            DataGridView1.RowTemplate.Height = 80;
            DataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            DataGridView1.ReadOnly = true;   //nap du lieu len

            //xu ly hinh anh (tham khao MSDN)
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();   //doi tuong lam viec voi dang picture cua datagridview
            DataGridView1.RowTemplate.Height = 80;
            DataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;   //stackoverflow
        }

       
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDeleteStudentForm updateDeletStdF = new UpdateDeleteStudentForm();
            /*
            //thu tu cua cac cot: id - fname - lname - bd - gdr - phn - adrs - pic
            updateDeletStdF.tb_studentid.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDeletStdF.tb_firstname.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDeletStdF.tb_lastname.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDeletStdF.dateTimePicker1.Value = (DateTime)DataGridView1.CurrentRow.Cells[3].Value;

            
            if ((DataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female"))
            {
                updateDeletStdF.radioButton_female.Checked = true;
            }
            else
            {
                updateDeletStdF.radioButton_male.Checked = true;
            }

            updateDeletStdF.tb_phone.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateDeletStdF.tb_address.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();

            //code xu ly hinh anh up len
            byte[] pic;
            pic = (byte[])DataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDeletStdF.pictureBox_imageStudent.Image = Image.FromStream(picture);*/

            updateDeletStdF.Show();
        }
    }
}
