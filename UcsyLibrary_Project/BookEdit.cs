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
    public partial class BookEdit : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\UcsyLibrary_Project\gcs.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter da;
        DataSet ds;

        public DataTable dt;
        public BookEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from booklist where id=@id", con);

            cmd.Parameters.AddWithValue("@id", id_input.Text);

            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);

            DataRow row = ds.Tables[0].Rows[0];

            name_input.Text = row["name"].ToString();
            type_input.Text = row["type"].ToString();
            author_input.Text = row["author"].ToString();
            country_input.Text = row["country"].ToString();
            date_input.Text = row["published_date"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String sql = "update booklist set name=@name,type=@type,author=@author,country=@country,published_date=@published_date "
                            + "where id=@id";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id_input.Text);
            cmd.Parameters.AddWithValue("@name", name_input.Text);
            cmd.Parameters.AddWithValue("@type", type_input.Text);
            cmd.Parameters.AddWithValue("@author", author_input.Text);
            cmd.Parameters.AddWithValue("@country", country_input.Text);
            cmd.Parameters.AddWithValue("@published_date", date_input.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Update successed!");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String del = "Delete from booklist where id=@id";

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
            BookAdd bookadd = new BookAdd();
            bookadd.Show();
            this.Hide();
        }
    }
}
