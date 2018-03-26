using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eric_10374246.DataAccess
{
 public   class DAO
    {
        private SqlConnection conn;

        public DAO()
        {
            conn = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ; Integrated Security = True; ");
        }

        public SqlConnection openConnection()
        {
            //Only need to open the connection if it's closed or broken
            if (conn.State == System.Data.ConnectionState.Closed || conn.State == System.Data.ConnectionState.Broken)
                conn.Open();
            return conn;
        }

        public void closeConnection()
        {
            //Only need to close the connection if it's open
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();

        }
    }
}
