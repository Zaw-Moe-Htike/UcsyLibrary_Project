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
    public partial class BookAdd : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\UcsyLibrary_Project\GCS.MDF;Integrated Security=True;Connect Timeout=30");        
        public BookAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into booklist(name,type,author,country,published_date)" +
                    "values(@name,@type,@author,@country,@date)", con);

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name", name_input.Text);
            cmd.Parameters.AddWithValue("@type", type_input.Text);
            cmd.Parameters.AddWithValue("@author", author_input.Text);
            cmd.Parameters.AddWithValue("@country", country_input.Text);
            cmd.Parameters.AddWithValue("@date", date_input.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Added!");
        }
    }
}
