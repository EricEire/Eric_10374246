using Business;
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
using Eric_10374246.DataAccess;

namespace Eric_10374246
{
    public partial class Form1 : Form
    {
        //private DataSet ds;
        public string level;
        List<Student> studentList = new List<Student>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string RadioChoice()
        {
            if (rbtnPostGrad.Checked == true)
            {
                level = "PostGraduate";
            }
            else if (rbtnUnderGrad.Checked == true)
            {
                level = "UnderGraduate";
            }
            return level;
        }

            private void btnAddStudent_Click(object sender, EventArgs e)
        {
            DAO dao = new DAO();

            dao.openConnection();

           Student.AddStudent(txtFN.Text, txtLN.Text, txtEmail.Text,txtPhone.Text,txtAdd1.Text,txtAdd2.Text, txtCity.Text, cmbCounty.Text,RadioChoice(), cmbCourses.Text, int.Parse(txtStudentNo.Text) );

            dao.closeConnection();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Restarts the application, thus returning to the login page
            Application.Restart();
        }

        private void aDDNEWSTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //same as btnAddStudent... may remove, seems pointless
            DAO dao = new DAO();

            dao.openConnection();

            Student.AddStudent(txtFN.Text, txtLN.Text, txtEmail.Text, txtPhone.Text, txtAdd1.Text, txtAdd2.Text, txtCity.Text, cmbCounty.Text, RadioChoice(), cmbCourses.Text, int.Parse(txtStudentNo.Text));

            dao.closeConnection();
        }



        private void fINDSTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            dao.openConnection();

            

        }
    }
}
