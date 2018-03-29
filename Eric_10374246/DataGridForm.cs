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
    public partial class DataGridForm : Form
    {
        public DataGridForm()
        {
            InitializeComponent();
        }

        private void DataGridForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'advProDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.advProDataSet.Student);

        }
    }
}
