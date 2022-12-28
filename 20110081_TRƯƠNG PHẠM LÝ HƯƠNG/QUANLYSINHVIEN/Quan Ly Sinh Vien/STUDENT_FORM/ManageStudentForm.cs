using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Sinh_Vien
{
    public partial class ManageStudentForm : Form
    {
        public ManageStudentForm()
        {
            InitializeComponent();
        }
        My_DB mydb = new My_DB();
        STUDENTS student = new STUDENTS();
        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("Select * From std"));
        }
        COURSES course = new COURSES();
        public void fillGrid(SqlCommand command)
        {
            DataGridViewInfo.ReadOnly = true;

            //Xử lý hình ảnh (tham khảo MSDN)
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();   //doi tuong lam viec voi dang picture cua datagridview
            DataGridViewInfo.RowTemplate.Height = 80;
            DataGridViewInfo.DataSource = student.getStudents(command);

            DataGridViewInfo.Columns[0].HeaderText = "Student ID";
            DataGridViewInfo.Columns[1].HeaderText = "First Name";
            DataGridViewInfo.Columns[2].HeaderText = "Last Name";
            DataGridViewInfo.Columns[3].HeaderText = "BirthDate";
            DataGridViewInfo.Columns[4].HeaderText = "Gender";
            DataGridViewInfo.Columns[5].HeaderText = "Phone";
            DataGridViewInfo.Columns[6].HeaderText = "Address";
            DataGridViewInfo.Columns[7].HeaderText = "Picture";

            picCol = (DataGridViewImageColumn)DataGridViewInfo.Columns["Picture"];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridViewInfo.AllowUserToAddRows = false;
           
            DataGridViewInfo.Columns.Add("course", "Selected Course");

            SqlCommand cmd = new SqlCommand("Select Distinct lable From Course", mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            adapter.Fill(table); 

            for (int i=0; i < DataGridViewInfo.Rows.Count-1; i++)
            {
                DataGridViewInfo[8, i].Value = table.Rows[i][0].ToString();
                
            }
            labelTotal.Text = "Total Student: " + DataGridViewInfo.Rows.Count;
        }

        private void DataGridViewInfo_Click(object sender, EventArgs e)
        {
            textboxstudenid.Text = DataGridViewInfo.CurrentRow.Cells[0].Value.ToString();
            textboxfname.Text = DataGridViewInfo.CurrentRow.Cells[1].Value.ToString();
            textboxlname.Text = DataGridViewInfo.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Value = (DateTime)DataGridViewInfo.CurrentRow.Cells[3].Value;

            //gender
            if((DataGridViewInfo.CurrentRow.Cells[4].Value.ToString().Replace(" ","") == "Male"))
            {
                radioButton_Male.Checked = true;
            }
            else
            {
                radioButtoon_Female.Checked = true;
            }

            textBoxPhone.Text = DataGridViewInfo.CurrentRow.Cells[5].Value.ToString();
            textboxAddress.Text = DataGridViewInfo.CurrentRow.Cells[6].Value.ToString();

            //image
            byte[] pic;
            pic = (byte[])DataGridViewInfo.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBoxImageStudent.Image = Image.FromStream(picture);
        }
        //****************************
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From std Where CONCAT(fname,lname,address) LIKE'%" + textboxSearch.Text + "%'", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridViewInfo.DataSource = table;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {

                STUDENTS student = new STUDENTS();
                int id = Convert.ToInt32(textboxstudenid.Text);
                string fname = textboxfname.Text;
                string lname = textboxlname.Text;
                DateTime bdate = dateTimePicker1.Value;
                string phone = textBoxPhone.Text;
                string adr = textboxAddress.Text;
                string gender = "Male";

                if (radioButtoon_Female.Checked)
                {
                    gender = "Female";
                }

                MemoryStream pic = new MemoryStream();
                int born_year = dateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;

                //sv tu 10-100, co the thay doi
                if (((this_year - born_year) < 10 || ((this_year - born_year) > 100)))
                {
                    MessageBox.Show("The Student Age Must Be 10 and 100 year", "Invalid Birth Date",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    pictureBoxImageStudent.Image.Save(pic, pictureBoxImageStudent.Image.RawFormat);
                    if (student.insertStudent(id, fname, lname, bdate, gender, phone, adr, pic))
                    {
                        MessageBox.Show("New Student Added", "Add Student",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Student",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Add Student",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                DataGridViewInfo.Columns.Clear();
                DataGridViewInfo.Refresh();

                fillGrid(new SqlCommand("select * from std"));
            }
            catch
            {
                MessageBox.Show("Invalid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id;
            string fname = textboxfname.Text;
            string lname = textboxlname.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBoxPhone.Text;
            string adr = textboxAddress.Text;
            string gender = "Male";

            if (radioButtoon_Female.Checked)
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
                    id = Convert.ToInt32(textboxstudenid.Text);
                    pictureBoxImageStudent.Image.Save(pic, pictureBoxImageStudent.Image.RawFormat);
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
            DataGridViewInfo.Columns.Clear();
            DataGridViewInfo.Refresh();

            fillGrid(new SqlCommand("select * from std"));
        }
        //chuc nang kiem tra du lieu input
        public bool verif()
        {
            if ((textboxfname.Text.Trim() == "")
                || (textboxlname.Text.Trim() == "")
                || (textboxAddress.Text.Trim() == "")
                || (textBoxPhone.Text.Trim() == "")
                || (pictureBoxImageStudent.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textboxstudenid.Text);

                //display a cofimation before the delete
                if ((MessageBox.Show("Are You Sure You Want To Delete This Student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (student.DeleteStudent(id))
                    {
                        MessageBox.Show("Student Deleted Successfully!!", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //clear after delete
                        textboxstudenid.Text = "";
                        textboxfname.Text = "";
                        textboxlname.Text = "";
                        textboxAddress.Text = "";
                        textBoxPhone.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        pictureBoxImageStudent.Image = null;
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
            DataGridViewInfo.Columns.Clear();
            DataGridViewInfo.Refresh();

            fillGrid(new SqlCommand("select * from std"));
        }

        private void button_UploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxImageStudent.Image = Image.FromFile(opf.FileName);
            }
        }

        private void textboxstudenid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textboxfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textboxlname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = "student_" + textboxstudenid.Text;
            if ((pictureBoxImageStudent.Image == null))
            {
                MessageBox.Show("No Image In The PictureBox");
            }
            else if ((svf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxImageStudent.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textboxstudenid.Text = "";
            textboxfname.Text = "";
            textboxlname.Text = "";
            textboxAddress.Text = "";
            textBoxPhone.Text = "";
            pictureBoxImageStudent.Image = null;
            radioButton_Male.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void DataGridViewInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CourseStudentList courseStudentList = new CourseStudentList();
            courseStudentList.Show();
        }
    }
}
