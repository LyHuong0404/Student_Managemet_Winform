using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Sinh_Vien
{
    class Group
    {
        My_DB mydb = new My_DB();
        public DataTable getAllGroup()  //count
        {
            SqlCommand command = new SqlCommand("select * from MyGroup", mydb.getConnection);
            
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        public bool insertGroup(int id, string group, int userid)
        {
            SqlCommand command = new SqlCommand("insert into MyGroup(Id, name, userid) values (@id, @gr, @userid)", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@gr", SqlDbType.NChar).Value = group;
            command.Parameters.Add("@userid", SqlDbType.Int).Value = userid;

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
        public bool updateGroup(int id, string group_id)
        {
            string query = "UPDATE MyGroup SET name = @gr where Id = @id";

            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@gr", SqlDbType.NChar).Value = group_id;

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
        public bool deleteGroup(int id)
        {
            SqlCommand command = new SqlCommand("DELETE from MyGroup where Id = @id", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

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
        public DataTable getGroupById(int Group_Id)
        {
            SqlCommand command = new SqlCommand("Select * From MyGroup where Id = @id", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = Group_Id;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public DataTable getGroupByUserId(int UserID)
        {
            SqlCommand command = new SqlCommand("Select * From MyGroup where userid = @uid", mydb.getConnection);

            command.Parameters.Add("@uid", SqlDbType.Int).Value = UserID;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public bool groupExist(string name, string operation, int userid, int groupid)
        {
            string query = "";

            SqlCommand cmd = new SqlCommand();

            if(operation == "add")
            {
                query = "select * from mygroup where name = @name and userid = @uid ";
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            }
            else if(operation == "edit")
            {
                query = "select * from mygroup where name = @name and userid = @uid and id <> @gid";
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
                cmd.Parameters.Add("@gid", SqlDbType.Int).Value = groupid;
            }

            cmd.Connection = mydb.getConnection;
            cmd.CommandText = query;

            SqlDataAdapter adpater = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpater.Fill(table);

            if(table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
