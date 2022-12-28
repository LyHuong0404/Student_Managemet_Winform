using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Sinh_Vien
{
    public class UserAccout
    {
        My_DB mydb = new My_DB();

        public void insertUser(int Id, string Username, string Password)
        {
            SqlCommand command = new SqlCommand("INSERT INTO log_in(id, username, password)" +
                " VALUES (@id, @user, @pw)", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = Id + 1;
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = Username;
            command.Parameters.Add("@pw", SqlDbType.VarChar).Value = Password;

            mydb.openConnection();

            command.ExecuteNonQuery(); //phương thức thực hiện các câu lệnh sql đến db
            
        }

        public bool updateUser(string username, string password)
        {
            SqlCommand command = new SqlCommand("UPDATE log_in SET password = @password WHERE username = @user", mydb.getConnection);

            command.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

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
    }
}
