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
            closeConnection();
        }

        public void showAllStudents(string firstName, string lastName, string email, string tel, string addL1, string addL2, string city, string county, string level, string course, int studentNo)
        {


            SqlCommand cmd = new SqlCommand("uspShowAllStudents", openConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();
            closeConnection();
        }

        public Student findStudent(int sn)
        {

            Student student1 = null;
            List<Student> studentList = new List<Student>();
            bool found = false;
            for (int i = 0; i < studentList.Count && !found; i++)
            {
                if (studentList[i].studentNo == sn)
                {
                    student1 = studentList[i];
                    found = true;
                }
            }
            return student1;
        }
    }
}
