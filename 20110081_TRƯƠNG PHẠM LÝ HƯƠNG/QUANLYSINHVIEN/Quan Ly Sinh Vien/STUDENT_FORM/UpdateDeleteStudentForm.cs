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
    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }

        STUDENTS student = new STUDENTS();
        BindingSource bindingSource = new BindingSource();

        //tim theo id, phan mo rong se tim hieu theo dien thoai, neu tim theo ten thi se xuat hien 1 form khac list toan bo ket qua trung ten
        private void bt_find_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tb_studentid.Text);
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM std WHERE id = " + id);

            DataTable table = student.getStudents(command);

            if (table.Rows.Count > 0)
            {
                tb_firstname.Text = table.Rows[0]["fname"].ToString();
                tb_lastname.Text = table.Rows[0]["lname"].ToString();
                dateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];

                
                if (table.Rows[0]["gender"].ToString().Replace(" ","") == "Male")
                {
                    radioButton_male.Checked = true;
                }
                else
                {
                    radioButton_female.Checked = true;
                }

                tb_phone.Text = table.Rows[0]["phone"].ToString();
                tb_address.Text = table.Rows[0]["address"].ToString();

                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox_imageStudent.Image = Image.FromStream(picture);
            }
            else
            {
                MessageBox.Show("Not found!!", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //Kiểm tra dữ liệu nhập vào là kí tự
        private void tb_studentid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void bt_search_Click(object sender, EventArgs e)
        {
            FindStudent Findstd = new FindStudent();
            Findstd.Show(this);
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            int id;
            string fname = tb_firstname.Text;
            string lname = tb_lastname.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = tb_phone.Text;
            string adr = tb_address.Text;
            string gender = "Male";

            if (radioButton_female.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;

            //sv tu 10-100, co the thay doi
            if (((this_year - born_year) < 10 || ((this_year - born_year) > 100)))
            {
                MessageBox.Show("The Student Age Must Be 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                try
                {
                    id = Convert.ToInt32(tb_studentid.Text);
                    pictureBox_imageStudent.Image.Save(pic, pictureBox_imageStudent.Image.RawFormat);
                    if (student.UpdateStudent(id, fname, lname, bdate, gender, phone, adr, pic))
                    {
                        MessageBox.Show("Student Updated Successfully!!", "Edit Student",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Student",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Error", "Edit Student",
                                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }      
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Student", 
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //chuc nang kiem tra du lieu input
        bool verif()
        {
            if ((tb_firstname.Text.Trim() == "")
                || (tb_lastname.Text.Trim() == "")
                || (tb_address.Text.Trim() == "")
                || (tb_phone.Text.Trim() == "")
                || (pictureBox_imageStudent.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void bt_remove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tb_studentid.Text);

                //display a cofimation before the delete
                if ((MessageBox.Show("Are You Sure You Want To Delete This Student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (student.DeleteStudent(id))
                    {
                        MessageBox.Show("Student Deleted Successfully!!", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //clear after delete
                        tb_studentid.Text = "";
                        tb_firstname.Text = "";
                        tb_lastname.Text = "";
                        tb_address.Text = "";
                        tb_phone.Text = "";
                        radioButton_female.Checked = false;
                        radioButton_male.Checked = false;
                        dateTimePicker1.Value = DateTime.Now;
                        pictureBox_imageStudent.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch             
            {
                MessageBox.Show("Please enter a valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_uploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox_imageStudent.Image = Image.FromFile(opf.FileName);
            }
        }

        private void tb_firstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tb_lastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tb_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_lastname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Down")
                tb_firstname.Focus();
            else if (e.KeyCode.ToString() == "Up")
                tb_firstname.Focus();
        }

        private void tb_studentid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Down")
                tb_firstname.Focus();
        }

        private void tb_firstname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Down")
            {
                tb_lastname.Focus();
            }
            else if (e.KeyCode.ToString() == "Up")
            {
                dateTimePicker1.Focus();
            }
        }

        private void tb_phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Right")
                tb_address.Focus();
        }

        BindingSource bs = null;
        My_DB mydb = new My_DB();
 
        public void UpdateDeleteStudentForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std", mydb.getConnection);


            DataTable table = student.getStudents(command);
            tb_studentid.Text = table.Rows[0]["Id"].ToString();
            tb_firstname.Text = table.Rows[0]["fname"].ToString();
            tb_lastname.Text = table.Rows[0]["lname"].ToString();
            dateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];

            //gender
            if (table.Rows[0]["gender"].ToString() == "Male")
            {
                //radioButton_female.Checked = true;
                radioButton_male.Checked = true;
            }
            else
            {
                //radioButton_male.Checked = true;
                radioButton_female.Checked = true;
            }

            tb_phone.Text = table.Rows[0]["phone"].ToString();
            tb_address.Text = table.Rows[0]["address"].ToString();

            byte[] pic = (byte[])table.Rows[0]["picture"];
            MemoryStream picture = new MemoryStream(pic);
            pictureBox_imageStudent.Image = Image.FromStream(picture);
            bindingSource.DataSource = table;

            /*
            adapter = new SqlDataAdapter("Select * from std", mydb.getConnection);
            mydb.openConnection();
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            dataset = new DataSet();
            adapter.Fill(dataset, "std");
            bs = new BindingSource(dataset, "std");

            
            tb_studentid.DataBindings.Add("Text", bs, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            tb_firstname.DataBindings.Add("Text", bs, "fname", true, DataSourceUpdateMode.OnPropertyChanged);
            tb_lastname.DataBindings.Add("Text", bs, "lname", true, DataSourceUpdateMode.OnPropertyChanged);
            dateTimePicker1.DataBindings.Add("Value", bs, "bdate", true, DataSourceUpdateMode.OnPropertyChanged);
            tb_phone.DataBindings.Add("Text", bs, "phone", true, DataSourceUpdateMode.OnPropertyChanged);
            tb_address.DataBindings.Add("Text", bs, "address", true, DataSourceUpdateMode.OnPropertyChanged);
            
            if (radioButton_male.Checked == true)
            {
                radioButton_male.DataBindings.Add("Checked", bs, "gender");
            }
            else
            {
                radioButton_female.DataBindings.Add("Checked", bs, "gender");
            }
            pictureBox_imageStudent.DataBindings.Add("Image", bs, "picture");*/
        }

        private void UpdateDeleteStudentForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Down")
                bs.Position++;

        }


        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            AddCourseFrm addCourse = new AddCourseFrm();
            AddCourseFrm addCourseFrm = new AddCourseFrm();
            addCourseFrm.textBoxStudentID.Text = tb_studentid.Text;
            addCourse.Show();
        }
    } 
}
