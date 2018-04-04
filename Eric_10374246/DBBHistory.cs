using Eric_10374246.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eric_10374246
{
    public partial class DBBHistory : Form
    {
        public DBBHistory()
        {
            InitializeComponent();
            Grid2();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        void Grid2()
        {
            DAO dao = new DAO();
            dao.openConnection();

            SqlDataAdapter sqlDa = new SqlDataAdapter("uspHistoryGrid", dao.openConnection());
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            dgHistory.DataSource = dt;


            dao.closeConnection();
        }
    }

}
