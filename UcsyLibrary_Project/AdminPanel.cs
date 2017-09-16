using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcsyLibrary_Project
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersCollection userscollection = new UsersCollection();
            userscollection.Show();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BooksCollection bookscollection = new BooksCollection();
            bookscollection.Show();
        }

        private void loansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoansCollection loancollection = new LoansCollection();
            loancollection.Show();
        }
    }
}
