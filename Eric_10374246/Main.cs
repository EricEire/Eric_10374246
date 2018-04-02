﻿using Business;
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
    public partial class Main : Form
    {
        DAO dao = new DAO();
        private DataSet ds;
        public string level;
        public Main()
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


        #region menu 
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
        #endregion


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
            DAO dao = new DAO();
            dao.openConnection();

            Student.UpdateStudent(txtFN.Text, txtLN.Text, txtEmail.Text, txtPhone.Text, txtAdd1.Text, txtAdd2.Text, txtCity.Text, cmbCounty.Text, cmbCourses.Text, RadioChoice(), int.Parse(txtStudentNo.Text));

            dao.closeConnection();

            txtFN.ReadOnly = false;
            txtLN.ReadOnly = false;
            MessageBox.Show("Student Updated");
            btnUpdate.Visible = false;
            ClearFields();
            Grid();

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
            txtSearch.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            dao.openConnection();
            Student.DeleteStudent(int.Parse(txtStudentNo.Text));
            dao.closeConnection();

            ClearFields();
            Grid();
       
            MessageBox.Show("Student Deleted");
            txtFN.ReadOnly = false;
            txtLN.ReadOnly = false;

            Grid();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {


            if (txtFileName.Text == "")
            {
                txtFileName.Text = "Students.xml";
            }

            
            DataTable dst = new DataTable();
            dst = (DataTable)dgStudents.DataSource;
            dst.TableName = "DataGridviewToXml";
            dst.WriteXml(txtFileName.Text);




            MessageBox.Show("XML Saved");

        }
    }
}
