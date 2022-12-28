using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Aspose.Words;//Thêm thư viện này (file Dll\Aspose.Word.dll)
using Aspose.Words.Tables;
using ThuVienWinform.Report.AsposeWordExtension;//thêm thư viện này (File Lib\ReportExtentionMethod.cs)


namespace Quan_Ly_Sinh_Vien
{
    public partial class AVGResultForm : Form
    {
        public AVGResultForm()
        {
            InitializeComponent();
        }

        My_DB mydb = new My_DB();
        STUDENTS student = new STUDENTS();
        STUDENT_SCORE stdScore = new STUDENT_SCORE();

        public void AddColumn()
        {

            dataGridView_information.Columns.Add("student_id", "Student ID");
            dataGridView_information.Columns.Add("fname", "First Name");
            dataGridView_information.Columns.Add("lname", "Last Name");

            DataGridViewImageColumn picol = new DataGridViewImageColumn();
            dataGridView_information.RowTemplate.Height = 60;

            dataGridView_information.Columns.Add(picol);
            picol = (DataGridViewImageColumn)dataGridView_information.Columns[3];
            picol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            picol.HeaderText = "Student Image";

            string query = "SELECT DISTINCT Course.lable " +
                       " FROM Course " +
                       " WHERE Course.semester = @sem";

            SqlCommand command = new SqlCommand(query, mydb.getConnection);

            command.Parameters.Add("@sem", SqlDbType.Int).Value = Convert.ToInt32(comboBoxSemester.Text);

            mydb.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            //add lable column 
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dataGridView_information.Columns.Add(table.Rows[i][0].ToString(), table.Rows[i][0].ToString());
            }
           
            dataGridView_information.Columns.Add("avgScore", "Average Score");
            dataGridView_information.Columns.Add("result", "Result");


        }
        public void AddStdValuesColumn(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);

            command.Parameters.Add("@sem", SqlDbType.Int).Value = Convert.ToInt32(comboBoxSemester.Text);

            mydb.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            //add in4 student
            for (int i = 0; i < table.Rows.Count; i++)
            {

                dataGridView_information.Rows.Add();

                for (int j = 0; j < table.Columns.Count; j++)
                {
                    if(j==3)
                    {
                        byte[] pic = (byte[])table.Rows[i]["picture"];
                        MemoryStream picture = new MemoryStream(pic);
                        dataGridView_information[j,i].Value = Image.FromStream(picture);
                    }
                    else dataGridView_information[j, i].Value = table.Rows[i][j].ToString();
                }
            }
        }

        public DataTable SearchStd()
        {
            string query = "Select Id FROM std " +
                            " WHERE CONCAT(fname, lname, address) LIKE'%" + textBoxSearch.Text + "%'";

            SqlCommand command = new SqlCommand(query, mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        public DataTable CountStd(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Parameters.Add("@sem", SqlDbType.Int).Value = Convert.ToInt32(comboBoxSemester.Text);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public void AddScore(string sqlCount, string query)
        {
            SqlCommand command = new SqlCommand("Select Distinct lable From Course Where semester = @sem", mydb.getConnection);
            
            command.Parameters.Add("@sem", SqlDbType.Int).Value = Convert.ToInt32(comboBoxSemester.Text);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            int countStd = CountStd(sqlCount).Rows.Count;

            for (int i = 0; i < countStd; i++)
            {
                for (int j = 0; j < table.Rows.Count; j++)
                {
                    SqlCommand cmd = new SqlCommand(query, mydb.getConnection);

                    cmd.Parameters.Add("@sem", SqlDbType.Int).Value = Convert.ToInt32(comboBoxSemester.Text);
                    cmd.Parameters.Add("@sid", SqlDbType.Int).Value = Convert.ToInt32(CountStd(sqlCount).Rows[i][0].ToString());
                    cmd.Parameters.Add("@Cname", SqlDbType.Char).Value = table.Rows[j][0].ToString();

                    SqlDataAdapter Adapter = new SqlDataAdapter(cmd);

                    DataTable table1 = new DataTable();
                    
                    Adapter.Fill(table1);

                    if (table1.Rows.Count > 0)
                    {
                        dataGridView_information[j + 4 , i].Value = table1.Rows[0][2].ToString();
                    }
                }
            }
        }

        public void AvgScore(string sqlCount, string query)
        {
            int countStd = CountStd(sqlCount).Rows.Count;
            int countColumn = dataGridView_information.Columns.Count;

            for (int i = 0; i < countStd; i++)
            {

                SqlCommand command = new SqlCommand(query, mydb.getConnection);

                command.Parameters.Add("@sem", SqlDbType.Int).Value = comboBoxSemester.SelectedItem;
                command.Parameters.Add("@sid", SqlDbType.Int).Value = Convert.ToInt32(CountStd(sqlCount).Rows[i][0].ToString());

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable table = new DataTable();

                adapter.Fill(table);

                float sumScore = 0;

                for (int j = 0; j < table.Rows.Count; j++)
                {
                    sumScore += Convert.ToInt32(table.Rows[j][2].ToString());
                }

                float AVGScore = (float)sumScore / (table.Rows.Count);

                dataGridView_information[countColumn - 2, i].Value = AVGScore;

                if (Convert.ToDouble(dataGridView_information[countColumn - 2, i].Value) >= 5)
                {
                    dataGridView_information[countColumn - 1, i].Value = "PASS";
                }
                else
                {
                    dataGridView_information[countColumn - 1, i].Value = "FAIL";
                }
            }
        }

        private void dataGridView_information_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxStudentID.Text = dataGridView_information.CurrentRow.Cells[0].Value.ToString();
            textBoxFirstName.Text = dataGridView_information.CurrentRow.Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridView_information.CurrentRow.Cells[2].Value.ToString();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            dataGridView_information.Rows.Clear();
            dataGridView_information.Columns.Clear();
            dataGridView_information.Refresh();

            AddColumn();

            AddStdValuesColumn("SELECT std.Id, std.fname, std.lname, std.picture" +
                              " FROM std join (SELECT DISTINCT Score.student_id, std.fname, std.lname" +
                                    " FROM (Course JOIN Score ON Course.Id = Score.course_id and Score.semester = Course.semester ) " +
                                    " JOIN std ON Score.student_id = std.Id " +
                                    " WHERE Course.semester = @sem AND (CONCAT(fname, lname, address) LIKE'%" + textBoxSearch.Text + "%')) as Q on std.Id = Q.student_id");

            AddScore("Select Id FROM std " +
                            " WHERE CONCAT(fname, lname, address) LIKE'%" + textBoxSearch.Text + "%'",

                                    "Select Score.student_id, Course.lable, Score.student_score " +
                                    " From (Course Join Score ON Course.Id = Score.course_id and Score.semester = Course.semester ) " +
                                    " Join std on Score.student_id = std.Id " +
                                    " WHERE Score.semester = @sem and Score.student_id = @sid and Course.lable = @Cname");

            AvgScore("Select Distinct Id FROM std " +
                            " WHERE CONCAT(fname, lname, address) LIKE'%" + textBoxSearch.Text + "%'",
                                "Select Score.student_id, Course.lable, Score.student_score " +
                                " From Course join Score on Score.course_id = Course.Id and Score.semester = Course.semester " +
                                " WHERE Course.semester = @sem and Score.student_id = @sid");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {

            int countCol = dataGridView_information.Columns.Count;
            var homNay = DateTime.Now;
            //Bước 1: Nạp file mẫu
            Document baoCao = new Document("Template\\MauBaoCao.docx");

            //Bước 2: Điền các thông tin cố định
            baoCao.MailMerge.Execute(new[] { "Ngay_Thang_Nam_BC" }, new[] { string.Format("TPHCM, ngày {0} tháng {1} năm {2}", homNay.Day, homNay.Month, homNay.Year) });
            baoCao.MailMerge.Execute(new[] { "MSSV" }, new[] { dataGridView_information.Rows[0].Cells[0].Value.ToString() });
            baoCao.MailMerge.Execute(new[] { "HO_TEN" }, new[] { dataGridView_information.Rows[0].Cells[2].Value.ToString().Replace(" ", "") + " " + dataGridView_information.Rows[0].Cells[1].Value.ToString().Replace(" ", "")});
            baoCao.MailMerge.Execute(new[] { "HocKi" }, new[] { comboBoxSemester.Text });
            baoCao.MailMerge.Execute(new[] { "DTB" }, new[] { dataGridView_information.Rows[0].Cells[countCol - 2].Value.ToString() });

            //Bước 3: Điền thông tin lên bảng
            Table bangThongTinDiem = baoCao.GetChild(NodeType.Table, 1, true) as Table;//Lấy bảng thứ 2 trong file mẫu
            int hangHienTai = 1;

            int countRowInsert = 0;
            for (int i = 4; i < (countCol - 2); i++)
            {
                if (dataGridView_information.Rows[0].Cells[i].Value != null)
                {
                    countRowInsert++;
                }
            }

            bangThongTinDiem.InsertRows(hangHienTai, hangHienTai, countRowInsert-1);

            for (int column = 1; column < (countCol - 5); column++)
            {
                if (dataGridView_information.Rows[0].Cells[column+3].Value != null)
                {
                    bangThongTinDiem.PutValue(hangHienTai, 0, hangHienTai.ToString());//Cột STT
                    bangThongTinDiem.PutValue(hangHienTai, 1, dataGridView_information.Columns[column+3].HeaderText);
                    bangThongTinDiem.PutValue(hangHienTai, 2, dataGridView_information.Rows[0].Cells[column+3].Value.ToString());
                    bangThongTinDiem.PutValue(hangHienTai, 3, dataGridView_information.Rows[0].Cells[countCol-1].Value.ToString());
                    hangHienTai++;
                }
            }

            //Bước 4: Lưu và mở file
            baoCao.SaveAndOpenFile("BaoCao.doc");

        }


        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            int countCol = dataGridView_information.Columns.Count;
            var homNay = DateTime.Now;
            //Bước 1: Nạp file mẫu
            Document baoCao = new Document("Template\\MauBaoCao.doc");

            //Bước 2: Điền các thông tin cố định
            baoCao.MailMerge.Execute(new[] { "Ngay_Thang_Nam_BC" }, new[] { string.Format("TPHCM, ngày {0} tháng {1} năm {2}", homNay.Day, homNay.Month, homNay.Year) });
            baoCao.MailMerge.Execute(new[] { "MSSV" }, new[] { dataGridView_information.Rows[0].Cells[0].Value.ToString() });
            baoCao.MailMerge.Execute(new[] { "HO_TEN" }, new[] { dataGridView_information.Rows[0].Cells[1].Value.ToString().Replace(" ","")  + " " + dataGridView_information.Rows[0].Cells[0].Value.ToString().Replace(" ","")});
            baoCao.MailMerge.Execute(new[] { "HocKi" }, new[] { comboBoxSemester.Text });
            baoCao.MailMerge.Execute(new[] { "DTB" }, new[] { dataGridView_information.Rows[0].Cells[countCol-2].Value.ToString() });

            //Bước 3: Điền thông tin lên bảng
            Table bangThongTinDiem = baoCao.GetChild(NodeType.Table, 1, true) as Table;//Lấy bảng thứ 2 trong file mẫu
            int hangHienTai = 1;
            bangThongTinDiem.InsertRows(hangHienTai, hangHienTai,12);
            for (int i = 1; i <= 4; i++)
            {
                bangThongTinDiem.PutValue(hangHienTai, 0, i.ToString());//Cột STT
                bangThongTinDiem.PutValue(hangHienTai, 1, dataGridView_information.Rows[-1].Cells[i+3].Value.ToString());//Cột Họ và tên
                bangThongTinDiem.PutValue(hangHienTai, 2, dataGridView_information.Rows[0].Cells[i + 3].Value.ToString());//Cột quan hệ
                bangThongTinDiem.PutValue(hangHienTai, 3, dataGridView_information.Rows[-1].Cells[countCol - 1].Value.ToString());//Cột Số điện thoại
                hangHienTai++;
            }

            //Bước 4: Lưu và mở file
            baoCao.SaveAndOpenFile("BaoCao.doc");
    
        }
        private void buttonShow_Click(object sender, EventArgs e)
        {
            dataGridView_information.Rows.Clear();
            dataGridView_information.Columns.Clear();
            dataGridView_information.Refresh();

            AddColumn();

            AddStdValuesColumn("SELECT std.Id, std.fname, std.lname, std.picture" +
                               " FROM std join (SELECT DISTINCT Score.student_id, std.fname, std.lname" +
                                     " FROM (Course JOIN Score ON Course.Id = Score.course_id and Score.semester = Course.semester ) " +
                                     " JOIN std ON Score.student_id = std.Id " +
                                     " WHERE Course.semester = @sem) as Q on std.Id = Q.student_id");

            AddScore("Select Distinct student_id From Score where Score.semester = @sem",
                                    "Select Score.student_id, Course.lable, Score.student_score " +
                                    " From (Course Join Score ON Course.Id = Score.course_id and Score.semester = Course.semester ) " +
                                    " Join std on Score.student_id = std.Id " +
                                    " WHERE Score.semester = @sem and Score.student_id = @sid and Course.lable = @Cname");

            AvgScore("Select Distinct student_id From Score where Score.semester = @sem",
                                "Select Score.student_id, Course.lable, Score.student_score " +
                                " From Course join Score on Score.course_id = Course.Id and Score.semester = Course.semester " +
                                " WHERE Course.semester = @sem and Score.student_id = @sid");
        }

    }
}
