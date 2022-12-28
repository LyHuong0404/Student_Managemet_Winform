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
    public partial class Login_Form : Form
    {
        SqlConnection SqlConnection;
        SqlCommand SqlCommand;
        string str = @"Data Source=(local);Initial Catalog=QUANLYSINHVIEN;Integrated Security=True";
        SqlDataAdapter SqlDataAdapter = new SqlDataAdapter();
        //tao table de nhan du lieu
        DataTable DataTable = new DataTable();
        My_DB mydb = new My_DB();
        public Login_Form()
        {
            InitializeComponent();
        }

        void loadData()
        {
            //load du lieu len 
            SqlCommand = SqlConnection.CreateCommand();
            //xu li ket noi
            SqlCommand.CommandText = "select * from log_in WHERE username=@User AND password=@Pass";

            SqlCommand.Parameters.Add("@User", SqlDbType.VarChar).Value = tb_username.Text;
            SqlCommand.Parameters.Add("@Pass", SqlDbType.VarChar).Value = tb_password.Text;

            //thuc thi cau truy van
            SqlDataAdapter.SelectCommand = SqlCommand;
            DataTable.Clear();

            //truyen du lieu tu adapter vao table
            SqlDataAdapter.Fill(DataTable);
        }
        void loadDataHR()
        {
            //load du lieu len 
            SqlCommand = SqlConnection.CreateCommand();
            //xu li ket noi
            SqlCommand.CommandText = "Select * From HR WHERE uname=@User AND pwd=@Pass";
            SqlCommand.Parameters.Add("@User", SqlDbType.VarChar).Value = tb_username.Text;
            SqlCommand.Parameters.Add("@Pass", SqlDbType.VarChar).Value = tb_password.Text;
            //thuc thi cau truy van
            SqlDataAdapter.SelectCommand = SqlCommand;
            DataTable.Clear();
            //truyen du lieu tu adapter vao table
            SqlDataAdapter.Fill(DataTable);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            if (radioButtonStudent.Checked == true)
            {
                loadData();
                if (DataTable.Rows.Count > 0)
                {

                    ProcessBar_login processValue = new ProcessBar_login();
                    processValue.labelName.Text = radioButtonStudent.Text;
                    processValue.Show(this);

                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (radioButtonHR.Checked == true)
            {
                loadDataHR();
                if (DataTable.Rows.Count > 0)
                {
                    this.DialogResult = DialogResult.OK;

                    ProcessBar_login processValue = new ProcessBar_login();
                    processValue.labelName.Text = radioButtonHR.Text;
                    processValue.labelHR_ID.Text = tb_username.Text;
                    processValue.Show(this);                
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../../images/OIP.jfif");
            //truyen vao chuoi ket noi
            SqlConnection = new SqlConnection(str);
            SqlConnection.Open();
            //loadData();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_register_Click(object sender, EventArgs e)
        {
            if (radioButtonHR.Checked == true)
            {
                NewAccout_HR newAccout = new NewAccout_HR();
                newAccout.Show();
            }
            else
            {
                Register_NewUser newUser = new Register_NewUser();
                newUser.Show(this);
            }
           
        }

        private void tb_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Down")
                tb_password.Focus();
        }

        private void tb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Up")
                tb_username.Focus();
        }

        private void labelQuenPass_Click(object sender, EventArgs e)
        {
            ForgetPassword forgetPassword = new ForgetPassword();
            Hide();
            forgetPassword.Show();
        }
    }
}
