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
    class User
    {
        My_DB mydb = new My_DB();

        public DataTable getUserById(Int32 userid)
        {
        
            string query = "SELECT * FROM HR WHERE Id = @uid";
            SqlCommand command = new SqlCommand(query, mydb.getConnection);

            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;

            mydb.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;

        }
        public bool insertUser(int id, string fname, string lname, string uname, string pwd, MemoryStream picture)
        {
            string query = "INSERT INTO HR (Id, f_name, l_name, uname, pwd, fig) VALUES (@id, @fn, @ln, @un, @pass, @pic)";
            
            SqlCommand command = new SqlCommand(query, mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id + 1;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = uname;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pwd;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();

            if(command.ExecuteNonQuery() == 1)
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

        public bool checkHR(int id, string uname)
        {
            string query = "SELECT * FROM HR WHERE Id = @Id and uname = @Username";

            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@Username", SqlDbType.NChar).Value = uname;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            adapter.Fill(table);

            mydb.openConnection();
            
            if (table.Rows.Count > 0)
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
        public bool checkHRedit(int id, string uname)
        {
            string query = "SELECT * FROM HR WHERE uname = @un AND id <> @uid";

            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            cmd.Parameters.Add("@uid", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@un", SqlDbType.NChar).Value = uname;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            adapter.Fill(table);

            mydb.openConnection();

            if (table.Rows.Count > 0)
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
        public bool usernameExist(string username, string operation, int userid =0)
        {
            string query = "";

            if (operation == "register")
            {
                query = "SELECT * FROM HR WHERE uname = @un";
            }
            else if (operation == "edit")
            {
                query = "SELECT * FROM HR WHERE uname = @un AND id <> @uid";
            }

            SqlCommand command = new SqlCommand(query, mydb.getConnection);

            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;

            mydb.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool updateUser (int id, string fname, string lname, string username, string password, MemoryStream picture)
        {
            string query = "UPDATE HR SET Id = @id, f_name = @fn, l_name = @ln, uname = @un, pwd = @pass, fig = @pic " +
                                " WHERE Id = @id";

            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
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
    
        public DataTable getUser()
        {
            string query = "SELECT * FROM HR";

            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);

            mydb.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
    }  
}
