using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Sinh_Vien
{
    public class Class_HR
    {
        My_DB mydb = new My_DB();
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable table;
        public bool checkClassExist(string cid, int sem)
        {
            string query = "select * from MyClass where course_id = @cid and semester = @sem";
            command = new SqlCommand(query, mydb.getConnection);
            
            command.Parameters.Add("@cid", SqlDbType.Char).Value = cid;
            command.Parameters.Add("@sem", SqlDbType.Int).Value = sem;

            adapter = new SqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);


            if(table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool insertClass(int contactID, string cid, int sem)
        {
            string query = "INSERT INTO MyClass (contact_id, course_id, semester) VALUES (@contactID, @cid, @sem)";

            SqlCommand command = new SqlCommand(query, mydb.getConnection);

            command.Parameters.Add("@contactID", SqlDbType.Int).Value = contactID;
            command.Parameters.Add("@cid", SqlDbType.VarChar).Value = cid;
            command.Parameters.Add("@sem", SqlDbType.Int).Value = sem;
 
            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
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
    }
}
