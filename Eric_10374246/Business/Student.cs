using Eric_10374246.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;



namespace Business
{
    class Student
    {
        static AddData data = new AddData();

        static SqlDataAdapter DA = new SqlDataAdapter();
        static List<Student> students = new List<Student>();
        public string firstName  { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string tel { get; set; }
        public string addL1 { get; set; }
        public string addL2 { get; set; }
        public string city { get; set; }
        public string county { get; set; }
        public string level { get; set; }
        public string course { get; set; }
        public int studentNo { get; set; }


        public Student(string fn, string ln, string e, string t, string a1, string a2, string c, string co, string l, string crs, int sn)
        {
            firstName = fn;
            lastName = ln;
            email = e;
            tel = t;
            addL1 = a1;
            addL2 = a2;
            city = c;
            county = co;
            level = l;
            course = crs;
            studentNo = sn;

        }

        public Student() { }

        public Student(int studentNo)
        {
            this.studentNo = studentNo;
        }

        public void addToDB()
        {
            data.addStudent(firstName,lastName,email,tel,addL1,addL2,city,county,level, course,studentNo);
        }

       


        public static void AddStudent(string fn, string ln, string e, string t, string a1, string a2, string c, string co, string l, string crs,  int sn)
        {
            Student s = new Student(fn,ln,e,t,a1,a2,c,co,l,crs,sn);
            students.Add(s);
            s.addToDB();
            
        }

        public static void DeleteStudent(int StudentNo)
        {
            Student s = new Student(StudentNo);
            s.removeFromDB(StudentNo);
        }
        public void removeFromDB(int StudentNo)
        {
          data.DeleteStudentSN(studentNo);
        }

        public static void UpdateStudent(string fn, string ln, string e, string t, string a1, string a2, string c, string co, string l, string crs, int sn)
        {

            data.updateStudent(fn, ln, e, t, a1, a2, c, co, l, crs, sn);
        }

    }
}
