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
    public partial class BooksCollection : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\UcsyLibrary_Project\GCS.MDF;Integrated Security=True;Connect Timeout=30");        
        public BooksCollection()
        {
            InitializeComponent();
        }

        private void BooksCollection_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BookList", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookEdit bookedit = new BookEdit();
            this.Hide();
            bookedit.Show();
        }
    }
}
