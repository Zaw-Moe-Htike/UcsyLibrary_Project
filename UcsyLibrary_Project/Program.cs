using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcsyLibrary_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new UsersCollection());
            //Application.Run(new UserRegister());
            //Application.Run(new UserEdit());
            Application.Run(new AdminPanel());
            //Application.Run(new LoginForm());
        }
    }
}
