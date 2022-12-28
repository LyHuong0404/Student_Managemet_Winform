using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Sinh_Vien
{
    public class COURSES
    {
        My_DB mydb = new My_DB();

        public bool checkCourseName(string courseName, string coursedId)
        {
            SqlCommand command = new SqlCommand("Select * From Course Where lable=@cName And Id <> @cID", mydb.getConnection);

            command.Parameters.Add("@cName", SqlDbType.NVarChar).Value = courseName;
            command.Parameters.Add("@cID", SqlDbType.VarChar).Value = coursedId;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public bool insertCourse(string id, string cName, int period, string description, int semester)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Course (Id, lable,period, description, semester)" +
                " VALUES (@id, @name, @hours, @descrip, @semester)", mydb.getConnection);

            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = cName;
            cmd.Parameters.Add("@hours", SqlDbType.Int).Value = period;
            cmd.Parameters.Add("@descrip", SqlDbType.Text).Value = description;
            cmd.Parameters.Add("@semester", SqlDbType.Int).Value = semester;

            mydb.openConnection();

            if ((cmd.ExecuteNonQuery() == 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool removeCourse(string id, int hocky)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Course Where Id = @cid and semester = @sem", mydb.getConnection);

            command.Parameters.Add("@cid", SqlDbType.Char).Value = id;
            command.Parameters.Add("@sem", SqlDbType.Int).Value = hocky;
            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateCourse(string id, string cName, int period, string description, int semester)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Course SET lable=@name, period=@hours, description=@descrip, semester = @semester WHERE Id=@id AND semester=@semester", mydb.getConnection);

            cmd.Parameters.Add("@id", SqlDbType.Char).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = cName;
            cmd.Parameters.Add("@hours", SqlDbType.Int).Value = period;
            cmd.Parameters.Add("@descrip", SqlDbType.Text).Value = description;
            cmd.Parameters.Add("@semester", SqlDbType.Int).Value = semester;

            mydb.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable getAllCourseDistinct()
        {
            SqlCommand command = new SqlCommand("Select Distinct lable From Course", mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        public DataTable getAllCourse()
        {
            SqlCommand command = new SqlCommand("Select * From Course", mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
  
        public DataTable getCourseById(string cid)
        {
            SqlCommand command = new SqlCommand("Select * From Course Where Id=@id", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Char).Value = cid;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        public DataTable getStudentCoursesByStdID(int studentID, int semester)
        {
            //lay nhung courses mà student da dang ky
            string query = "SELECT Course.Id as CourseID, Course.lable as CourseName, Course.semester as Semester FROM Score INNER JOIN Course ON " +
                           " Score.course_id = Course.Id AND Score.student_id = @studentID AND Score.semester = @se AND Course.semester=@se";
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);

            cmd.Parameters.Add("@studentID", SqlDbType.Int).Value = studentID;
            cmd.Parameters.Add("@se", SqlDbType.Int).Value = semester;
            mydb.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        public DataTable getCourseBySemester(int semester)
        {
            string query = "Select * From Course Where semester = @se";
            SqlCommand command = new SqlCommand(query, mydb.getConnection);

            command.Parameters.Add("@se", SqlDbType.Int).Value = semester;

            mydb.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        string exeCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            String count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
        public string totalCourse()
        {
            return exeCount("Select Count(*) From Course");
        }
    }
}
