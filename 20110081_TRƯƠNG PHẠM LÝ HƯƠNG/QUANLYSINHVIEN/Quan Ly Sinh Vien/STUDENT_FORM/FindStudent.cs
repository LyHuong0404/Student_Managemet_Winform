using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Sinh_Vien
{
    public partial class FindStudent : Form
    {
        public List<LoaiTimKiem> loai = new List<LoaiTimKiem>();
        
        STUDENTS student = new STUDENTS();

        SqlCommand command;

        DataTable table = new DataTable();
        public FindStudent()
        {
            InitializeComponent();
            AddLoaiTimKiem();
            comboBox1.DataSource = loai;
            comboBox1.DisplayMember = "TimTheo";
        }

        public class LoaiTimKiem
        {
            public string TimTheo { get; set; }
        }

        public void AddLoaiTimKiem()
        {
            loai.Add(new LoaiTimKiem() { TimTheo = "Phone Number" });
            loai.Add(new LoaiTimKiem() { TimTheo = "First Name" });
        }

        private void FindStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYSINHVIENDataSet.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter.Fill(this.qUANLYSINHVIENDataSet.std);
        }

        private void bt_search_Click(object sender, EventArgs e)
        { 
            if (comboBox1.Text == "Phone Number")
            {
                command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM std WHERE phone = " + tb_search.Text);
                table = student.getStudents(command);
            }
            else
            {
                command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM std WHERE CONCAT(fname,lname) LIKE '%" + tb_search.Text + "%'");
                table = student.getStudents(command);
            }


            if (table.Rows.Count > 0)
            {
                dataGridView1.ReadOnly = true;

                //xu ly hinh anh (tham khao MSDN)
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();   //doi tuong lam viec voi dang picture cua datagridview
                dataGridView1.RowTemplate.Height = 80;
                dataGridView1.DataSource = table;
                picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridView1.AllowUserToAddRows = false;
            }
            else
            {
                MessageBox.Show("Wrong information!!", "Find Student", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
