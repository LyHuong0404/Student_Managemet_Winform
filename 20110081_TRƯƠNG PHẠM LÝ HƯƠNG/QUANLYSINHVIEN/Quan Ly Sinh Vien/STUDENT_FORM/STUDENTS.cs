using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Sinh_Vien
{
    public class STUDENTS
    {
        My_DB mydb = new My_DB();

        //function to insert a new std
        public bool insertStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO std (id, fname, lname, bdate, gender, phone, address, picture)" +
                " VALUES (@id, @fn, @ln, @bdt, @gdr, @phn, @adr, @pic)", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;

            ////////command = new SqlCommand("Select Id From std");
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)  // phương thức thực hiện các câu lệnh SQL đến dữ liệu nguồn và nhận về số lượng hàng bị
                                                 //tác động ví dụ Update, Delete
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        
        public DataTable getNameStudent(int studentID)
        {
            string query = "SELECT Id, fname, lname FROM std WHERE Id = @sid";
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            cmd.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;

            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool UpdateStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE std SET fname=@fn, lname=@ln, bdate=@bdt, gender=@gdr," +
               "phone=@phn, address=@adr, picture=@pic WHERE Id=@id", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)  // phương thức thực hiện các câu lệnh SQL đến dữ liệu nguồn và nhận về số lượng hàng bị
                                                 //tác động ví dụ Update, Delete
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool DeleteStudent(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM std WHERE id = @id", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.openConnection();
                return true;
            }
            else
            {
                mydb.openConnection();
                return false;
            }
        }

        string exeCount(string query)
        {
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            String count = cmd.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
        public string totalStudent()
        {
            return exeCount("Select count(*) From std");
        }
        public string totalMaleStudent()
        {
            return exeCount("Select count(*) From std Where gender='Male'");
        }
        public string totalFemaleStudent()
        {
            return exeCount("Select count(*) From std Where gender='Female'");
        }

    }
}
