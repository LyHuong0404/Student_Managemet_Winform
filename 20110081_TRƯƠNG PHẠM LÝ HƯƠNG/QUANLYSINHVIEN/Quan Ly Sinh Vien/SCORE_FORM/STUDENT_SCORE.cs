using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Sinh_Vien
{
    class STUDENT_SCORE
    {
        My_DB mydb = new My_DB();
        public bool insertScore (int studentID, string courseID, double score, string des, int semester)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Score SET student_score= @stdScore, description = @des WHERE student_id = @sid AND course_id = @cid AND semester=@se ", mydb.getConnection);
            
            cmd.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            cmd.Parameters.Add("@cid", SqlDbType.Char).Value = courseID;
            cmd.Parameters.Add("@stdscore", SqlDbType.Float).Value = score;
            cmd.Parameters.Add("@des", SqlDbType.VarChar).Value = des;
            cmd.Parameters.Add("@se", SqlDbType.Float).Value = semester;

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

        //ktra trung
        public bool studentScoreExist(int studentId, string courseID)
        {
            string query = "SELECT * FROM Score WHERE student_id = @sid AND course_id = @cid";

            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            cmd.Parameters.Add("@sid", SqlDbType.Int).Value = studentId;
            cmd.Parameters.Add("@cid", SqlDbType.Char).Value = courseID;
            
            mydb.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if((table.Rows.Count >0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public DataTable AvgScore()
        {         
            string query = "Select Course.lable as CourseName, round(AVG(Score.student_score),2) as AverageGrade From Course, Score " +
                " WHERE Course.Id = Score.course_id   GROUP BY Course.lable";

            SqlCommand command = new SqlCommand(query, mydb.getConnection);

            mydb.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            
            adapter.Fill(table);

            return table;
        }


        //delete score bang student_id va course_id
        public bool deleteScore(int studentid, string courseid, int semester)
        {
            string query = "DELETE FROM Score WHERE student_id = @sid AND course_id = @cid AND semester = @se";
            
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            cmd.Parameters.Add("@sid", SqlDbType.Int).Value = studentid;
            cmd.Parameters.Add("@cid", SqlDbType.Char).Value = courseid;
            cmd.Parameters.Add("@se", SqlDbType.Int).Value = semester;

            mydb.openConnection();

            if(cmd.ExecuteNonQuery() == 1)
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
        public DataTable getNameCourseAndScore(int studentID)
        {
            string query = "Select Score.student_id, std.fname, std.lname, Score.course_id, Course.lable, Score.student_score, Score.description, Score.semester " +
                 " from (Course join Score on Course.Id = Score.course_id) join std on Score.student_id = std.id WHERE Score.semester = Course.semester AND Score.student_id = @sid";

            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            cmd.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;

            mydb.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        public DataTable getCoursesScores()
        {
            string query = "select Score.student_id, std.fname, std.lname, Score.course_id, Course.lable, Score.student_score, Score.description, Score.semester " +
                 " from (Course join Score on Course.Id = Score.course_id) join std on Score.student_id = std.id WHERE Score.semester = Course.semester";


            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            mydb.openConnection();

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;

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
            return exeCount("Select count(*) From Score");
        }
        public string getCountPass()
        {
            return exeCount("Select count(*) From Score Where student_score >= 5");
        }
        public DataTable getCourseScores(int courseId)
        {
            string query = "SELECT Score.student_id, std.fname, std.lname, Score.course_id, " +
               " Course.lable, Score.student_score, Course.semester" +
               " FROM std INNER JOIN Score ON std.Id = Score.student_id" +
               " INNER JOIN Course ON Score.course_id = Course.Id WHERE Score.course_id = " + courseId;

            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;

        }
        public DataTable getStudentsScore()
        {
            string query = "SELECT Score.student_id as StudentID, std.fname as FirstName, std.lname as LastName, " +
                " Score.course_id as CourseID, Score.student_score as Student_Score, Score.semester as Semester" +
                " FROM std INNER JOIN Score ON std.Id = Score.student_id";
               
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);

            mydb.openConnection();
            
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
    }
}
