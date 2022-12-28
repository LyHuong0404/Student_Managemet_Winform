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
    class CONTACT
    {
        My_DB mydb = new My_DB();

        public bool insertContact(int Id, string fname, string lname, string phone, string address, string email, int userid, int groupid, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("insert into mycontact (Id, fname, lname, group_id, phone, email, address, userid, pic) values (@Id, @fn, @ln, @grp, @phn, @mail, @adrs, @uid, @pic)", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@grp", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

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

        public bool updateContact(int contactid, string fname, string lname, int groupid, string phone, string email, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("update mycontact set fname = @fn, lname = @ln, group_id = @grp, phone = @phn, email = @mail, address = @adrs, userid =@uid, pic= @pic where Id = @contactid", mydb.getConnection);
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@grp", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@contactid", SqlDbType.Int).Value = contactid;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.GlobalUserId;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

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

        public bool deleteContact(int contactid)
        {
            SqlCommand command = new SqlCommand("delete from mycontact where id = @id", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = contactid;

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
        public DataTable selectContactByUserID(int userid)
        {
            SqlCommand cmd = new SqlCommand("select * from mycontact where userid = " + userid, mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable selectContactList(SqlCommand command)
        {
            command.Connection = mydb.getConnection;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public DataTable getContactById(int contactId)
        {
            SqlCommand command = new SqlCommand("select fname, lname, group_id, phone, email, address, userid, pic from mycontact where id=@id", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable selectContactList()
        {
            SqlCommand command = new SqlCommand("Select * from mycontact", mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public bool checkContactID(int contactID)
        {
            string query = "SELECT * FROM mycontact WHERE Id = @cid";

            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);

            cmd.Parameters.Add("@cid", SqlDbType.NChar).Value = contactID;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            adapter.Fill(table);

            mydb.openConnection();

            if (table.Rows.Count > 0)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }

    }
}