using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eric_10374246.DataAccess;


namespace Eric_10374246
{
    public partial class Login : Form
    {
        LoginData login = new LoginData("DBS","pwd123");
        
        public Login()
        {
            InitializeComponent();
        }
       

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exits application
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            //define local variables from the user inputs 
            string user = txtUsername.Text;
            string pass = txtPwd.Text;
            //check if eligible to be logged in 
            if (login.IsLoggedIn(user, pass))
            {

                form.Show();
                
            }
            else
            {
                //show default login error message 
                MessageBox.Show("Invalid Login");
            }
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            //same as btnLogin. 
            Main form = new Main();
            //define local variables from the user inputs 
            string user = txtUsername.Text;
            string pass = txtPwd.Text;
            //check if eligible to be logged in 
            if (login.IsLoggedIn(user, pass))
            {

                form.Show();

            }
            else
            {
                //show default login error message 
                MessageBox.Show("Invalid Login");
            }

        }
    }
}

