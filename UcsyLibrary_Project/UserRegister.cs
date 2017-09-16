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
    public partial class UserRegister : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\UcsyLibrary_Project\GCS.MDF;Integrated Security=True;Connect Timeout=30");
        public UserRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into useracc(name,email,phone,address,type,password)" +
                    "values(@name,@email,@phone,@address,'User',@password)", con);

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name", name_input.Text);
            cmd.Parameters.AddWithValue("@email", email_input.Text);
            cmd.Parameters.AddWithValue("@phone", phone_input.Text);
            cmd.Parameters.AddWithValue("@address", address_input.Text);
            cmd.Parameters.AddWithValue("@password", password_input.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Registration Finished!");
        }
    }
}
