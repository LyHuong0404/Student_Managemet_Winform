using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Quan_Ly_Sinh_Vien
{
    //file quản lý kết nối database
    public class My_DB
    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=QUANLYSINHVIEN;Integrated Security=True");


        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }

        
        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }
        }
    } 
}
