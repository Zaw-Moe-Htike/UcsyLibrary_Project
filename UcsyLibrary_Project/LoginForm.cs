using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UcsyLibrary_Project
{
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\UcsyLibrary_Project\gcs.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter da;
        DataSet ds;

        public DataTable dt;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from useracc where email=@email and password=@password", con);
                con.Open();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@email", email_input.Text);
                cmd.Parameters.AddWithValue("@password", password_input.Text);

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                DataRow row = ds.Tables[0].Rows[0];
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows == true)
                {
                    String type = row["type"].ToString();
                    if (type.Equals("Admin     "))
                    {
                        AdminPanel adminpanel = new AdminPanel();
                        this.Hide();
                        adminpanel.Show();
                    }
                    else
                    {
                        UserPanel userpanel = new UserPanel();
                        this.Hide();
                        userpanel.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }
                con.Close();
            }
            catch (Exception) { MessageBox.Show("Exception Error!"); }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegister userregister = new UserRegister();
            userregister.Show();
        }
    }
}
