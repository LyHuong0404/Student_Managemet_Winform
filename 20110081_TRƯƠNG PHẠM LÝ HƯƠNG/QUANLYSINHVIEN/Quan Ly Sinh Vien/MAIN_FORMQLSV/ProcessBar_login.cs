using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Sinh_Vien
{
    public partial class ProcessBar_login : Form
    {
        My_DB mydb = new My_DB();
        public ProcessBar_login()
        {
            InitializeComponent();
        }

        private void ProcessBar_login_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Increment(1);
            progressBar1.PerformStep();
            lb_ready.Text = " Loading " + progressBar1.Value.ToString() + "%";

            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Enabled = !timer1.Enabled;
                this.Hide();
                if (labelName.Text == "Human Resource")
                {
                    ContactAndGroup contactandgroup = new ContactAndGroup();

                    SqlCommand command = new SqlCommand("Select * From HR where uname = @Uname", mydb.getConnection);

                    command.Parameters.Add("@Uname", SqlDbType.Char).Value = labelHR_ID.Text;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    int userID = Convert.ToInt32(table.Rows[0]["Id"].ToString());
                   
                    Globals.SetGlobalUserId(userID);

                    contactandgroup.labelWelcome.Text = "(" + labelHR_ID.Text + ")";
                    contactandgroup.labelHRName.Text = table.Rows[0]["f_name"].ToString().Replace(" ","") + " " + table.Rows[0]["l_name"].ToString().Replace(" ", "");
                    byte[] pic = (byte[])table.Rows[0]["fig"];
                    MemoryStream picture = new MemoryStream(pic);
                    contactandgroup.pictureBoxHR.Image = Image.FromStream(picture);
                    contactandgroup.ShowDialog(this);

                }
                else
                {
                    MainForm01 mainForm = new MainForm01();
                    mainForm.Show(this);
                }
            }
        }
    }
}
