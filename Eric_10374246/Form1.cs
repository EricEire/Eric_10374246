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

namespace Eric_10374246
{
    public partial class Form1 : Form
    {
        private DataSet ds;
        string level;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RadioChoice(object sender, EventArgs e)
        {
            if (rbtnPostGrad.Checked == true)
            {
                level = "PostGraduate";
            }
            else if (rbtnUnderGrad.Checked == true)
            {
                level = "UnderGraduate";
            }
        }

            private void btnAddStudent_Click(object sender, EventArgs e)
        {
            DataTable dt;

            Student.AddStudent(txtFN.Text, txtLN.Text, txtEmail.Text,txtPhone.Text,txtAdd1.Text,txtAdd2.Text, txtCity.Text, cmbCounty.Text,level, cmbCourses.Text, int.Parse(txtStudentNo.Text) );

            output.Text = "Student Added";
        }
    }
}
