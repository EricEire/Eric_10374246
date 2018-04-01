using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;

namespace Eric_10374246.DataAccess
{
    class AddData:DAO
    {
        

        public void addStudent(string firstName, string lastName, string email, string tel, string addL1, string addL2, string city, string county, string level, string course, int studentNo)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Student VALUES(@studentNo,@FName, @LName, @email, @phone, @addressL1, @addressL2, @city," +
                " @county, @level, @course)", openConnection());
            try
            {
                cmd.Parameters.AddWithValue("@studentNo", studentNo);
                cmd.Parameters.AddWithValue("@FName", firstName);
                cmd.Parameters.AddWithValue("@LName", lastName);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", tel);
                cmd.Parameters.AddWithValue("@addressL1", addL1);
                cmd.Parameters.AddWithValue("@addressL2", addL2);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@county", county);
                cmd.Parameters.AddWithValue("@level", level);
                cmd.Parameters.AddWithValue("@course", course);

                cmd.ExecuteNonQuery();
            }
             catch(Exception)
            {
                throw;
            }
            closeConnection();
        }


        public void DeleteStudentSN(int studentNo)
        { 
           
            openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Student WHERE studentNo=@StudentNo",openConnection());
                cmd.Parameters.AddWithValue("@StudentNo", studentNo);
                cmd.ExecuteNonQuery();
                
            }catch(Exception)
            {
                throw new Exception("No student to remove");
            }
            closeConnection();

        }

            //public void showAllStudents(string firstName, string lastName, string email, string tel, string addL1, string addL2, string city, string county, string level, string course, int studentNo)
            //{


            //    SqlCommand cmd = new SqlCommand("uspFillDataGrid", openConnection());
            //    cmd.CommandType = CommandType.StoredProcedure;

            //    cmd.ExecuteNonQuery();
            //    closeConnection();
            //}

            public void updateStudent(string firstName, string lastName, string email, string tel, string addL1, string addL2, string city, string county, string level, string course, int studentNo)
        {

            SqlDataAdapter DA = new SqlDataAdapter(
          "SELECT *  FROM Student",
          openConnection());

            DA.UpdateCommand = new SqlCommand(
               "UPDATE Student SET PhoneNo = @PhoneNo,Email=@Email,AddressLine1=@AddressLine1,AddressLine2=@AddressLine2,City=@City,County=@County " +
               "WHERE StudentNo = @StudentNo", openConnection());

            DA.UpdateCommand.Parameters.Add(
                "@PhoneNo", SqlDbType.VarChar, 20, "PhoneNo");
            DA.UpdateCommand.Parameters.Add(
               "@Email", SqlDbType.VarChar, 100, "Email");
            DA.UpdateCommand.Parameters.Add(
               "@AddressLine1", SqlDbType.VarChar, 100, "AddressLine1");
            DA.UpdateCommand.Parameters.Add(
                "@AddressLine2", SqlDbType.VarChar, 100, "AddressLine2");
            DA.UpdateCommand.Parameters.Add(
                "@City", SqlDbType.VarChar, 50, "City");
            DA.UpdateCommand.Parameters.Add(
               "@County", SqlDbType.VarChar, 50, "County");

            SqlParameter parameter = DA.UpdateCommand.Parameters.Add(
              "@StudentNo", SqlDbType.Int);
            parameter.SourceColumn = "StudentNo";
            parameter.SourceVersion = DataRowVersion.Original;

            DataTable studentTable = new DataTable();
            DA.Fill(studentTable);

            DataRow studentRow = studentTable.Rows[0];
            studentRow["PhoneNo"] = "PhoneNo";

            DA.Update(studentTable);

            #region close
            //SqlCommand cmd = new SqlCommand("UPDATE Student VALUES(@studentNo,@FName, @LName, @email, @phone, @addressL1, @addressL2, @city," +
            //    " @county, @level, @course)", openConnection());
            //try
            //{

            //    cmd.Parameters.AddWithValue("@email", email);
            //    cmd.Parameters.AddWithValue("@phone", tel);
            //    cmd.Parameters.AddWithValue("@addressL1", addL1);
            //    cmd.Parameters.AddWithValue("@addressL2", addL2);
            //    cmd.Parameters.AddWithValue("@city", city);
            //    cmd.Parameters.AddWithValue("@county", county);
            //    cmd.Parameters.AddWithValue("@level", level);

            //    cmd.ExecuteNonQuery();
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
            //closeConnection();


            //cmd.ExecuteNonQuery();
            //closeConnection();
            #endregion
        }
    }
}
