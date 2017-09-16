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
    public partial class UserEdit : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\UcsyLibrary_Project\gcs.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter da;
        DataSet ds;

        public DataTable dt;
        public UserEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from useracc where id=@id", con);

            cmd.Parameters.AddWithValue("@id", id_input.Text);

            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);

            DataRow row = ds.Tables[0].Rows[0];

            name_input.Text = row["name"].ToString();
            email_input.Text = row["email"].ToString();
            phone_input.Text = row["phone"].ToString();
            address_input.Text = row["address"].ToString();
            if (row["type"].ToString().Equals("User"))
            {

            }
            if (row["type"].ToString().Equals("Admin"))
            {

            }
            password_input.Text = row["password"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String sql = "update useracc set name=@name,email=@email,phone=@phone,address=@address,password=@password "
                            + "where id=@id";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id_input.Text);
            cmd.Parameters.AddWithValue("@name", name_input.Text);
            cmd.Parameters.AddWithValue("@email", email_input.Text);
            cmd.Parameters.AddWithValue("@phone", phone_input.Text);
            cmd.Parameters.AddWithValue("@address", address_input.Text);
            cmd.Parameters.AddWithValue("@password", password_input.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Update successed!");
            con.Close();
        }

        private void UserEdit_Load(object sender, EventArgs e){}

        private void button3_Click(object sender, EventArgs e)
        {
            String del = "Delete from useracc where id=@id";

            SqlCommand cmd = new SqlCommand(del, con);

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id_input.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Delete successed!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserRegister userregister = new UserRegister();
            userregister.Show();
            this.Hide();
        }
    }
}
