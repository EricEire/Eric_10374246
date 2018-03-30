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
        DAO dao = new DAO();
        //private DataSet ds;
        public string level;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Grid();
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
            ClearFields();
            Grid();
            MessageBox.Show("Student Successfully Added");
            
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

            ClearFields();
            Grid();
            MessageBox.Show("Student Successfully Added");
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            dao.openConnection();

            SqlDataAdapter sqlDa = new SqlDataAdapter("uspFillDataGrid", dao.openConnection());
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@StudentNo", txtSearch.Text);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            dgStudents.DataSource = dt;
            

            dao.closeConnection();
        }

        void ClearFields()
        {
            txtFN.Text = "";
            txtLN.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAdd1.Text = "";
            txtAdd2.Text = "";
            txtCity.Text = "";
            txtStudentNo.Text = "";
            
        }

        void Grid()
        {
            DAO dao = new DAO();
            dao.openConnection();

            SqlDataAdapter sqlDa = new SqlDataAdapter("uspGrid", dao.openConnection());
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            dgStudents.DataSource = dt;


            dao.closeConnection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dao.openConnection();
            SqlCommand cmd = new SqlCommand("update Student set PhoneNo=@PhoneNo,AddressLine1=@AddressLine1," +
                $"AddressLine2=@AddressLine2, City=@City,County=@County,StudentNo=@StudentNo  where StudentNo={txtStudentNo.Text}", dao.openConnection());
            cmd.Parameters.AddWithValue("@PhoneNo", txtPhone.Text);
            cmd.Parameters.AddWithValue("@AddressLine1", txtAdd1.Text);
            cmd.Parameters.AddWithValue("@AddressLine2", txtAdd2.Text);
            cmd.Parameters.AddWithValue("@City", txtCity.Text);
            cmd.Parameters.AddWithValue("@County", cmbCounty.Text);
            cmd.Parameters.AddWithValue("@StudentNo", txtStudentNo.Text);

            cmd.ExecuteNonQuery();


            txtFN.ReadOnly = false;
            txtLN.ReadOnly = false;
            MessageBox.Show("Student Updated");
            ClearFields();
            Grid();
            dao.closeConnection();
        }

        private void dgStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgStudents.CurrentRow.Index != -1)
            {
                txtFN.Text = dgStudents.CurrentRow.Cells[1].Value.ToString();
                txtLN.Text = dgStudents.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = dgStudents.CurrentRow.Cells[3].Value.ToString();
                txtPhone.Text = dgStudents.CurrentRow.Cells[4].Value.ToString();
                txtAdd1.Text = dgStudents.CurrentRow.Cells[5].Value.ToString();
                txtAdd2.Text = dgStudents.CurrentRow.Cells[6].Value.ToString();
                txtCity.Text = dgStudents.CurrentRow.Cells[7].Value.ToString();
                cmbCounty.Text = dgStudents.CurrentRow.Cells[8].Value.ToString();
                level = dgStudents.CurrentRow.Cells[9].Value.ToString();
                cmbCourses.Text = dgStudents.CurrentRow.Cells[10].Value.ToString();
                txtStudentNo.Text = dgStudents.CurrentRow.Cells[0].Value.ToString();


                txtFN.ReadOnly = true;
                txtLN.ReadOnly = true;
                

                btnUpdate.Visible = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Grid();
        }
    }
}
